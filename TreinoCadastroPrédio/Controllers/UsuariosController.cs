﻿using GerenciadorCondominios.BLL.Models;
using GerendiadorCondominos.DAL.Intefaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TreinoCadastroPrédio.ViewlModels;

namespace TreinoCadastroPrédio.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UsuariosController(IUsuarioRepositorio usuarioRepositorio, IWebHostEnvironment webHostEnvironment)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult>  Registro(RegistroViewModel model, IFormFile  foto)
        {
            if (ModelState.IsValid)
            {
                if(foto != null)
                {
                    string diretorioPasta = Path.Combine(_webHostEnvironment.WebRootPath, "Imagens");
                    string nomeFoto = Guid.NewGuid().ToString() + foto.FileName;

                    using (FileStream fileStream = new FileStream(Path.Combine(diretorioPasta, nomeFoto), FileMode.Create))
                    {
                        await foto.CopyToAsync(fileStream);
                        model.Foto = "~/Imagens/" + nomeFoto;
                    }
                }

                Usuario usuario = new Usuario();
                IdentityResult usuarioCriado;

                if (_usuarioRepositorio.VerificarSeExisteRegistro() == 0)
                {
                    usuario.UserName = model.Nome;
                    usuario.CPF = model.CPF;
                    usuario.Email = model.Email;
                    usuario.PhoneNumber = model.Telefone;
                    usuario.Foto = model.Foto;
                    usuario.PrimeiroAcesso = false;
                    usuario.Status = StatusConta.Aprovado;

                    usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                    if (usuarioCriado.Succeeded)
                    {
                        await _usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, "Administrador");
                        await _usuarioRepositorio.LogarUsuario(usuario, false);
                        return RedirectToAction("Index", "Usuario");
                    }
                }

                usuario.UserName = model.Nome;
                usuario.CPF = model.CPF;
                usuario.Email = model.Email;
                usuario.PhoneNumber = model.Telefone;
                usuario.Foto = model.Foto;
                usuario.PrimeiroAcesso = false;
                usuario.Status = StatusConta.Analisando;

                usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                if (usuarioCriado.Succeeded)
                {
                    return View("Analise", usuario.UserName);
                }
                else
                {
                    foreach(IdentityError erro in usuarioCriado.Errors)
                    {
                        ModelState.AddModelError("", erro.Description);
                    }
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if (User.Identity.IsAuthenticated)
                await _usuarioRepositorio.DeslogarUsuario();

            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = await _usuarioRepositorio.PegarUsuarioPorEmail(model.Email);

                if (usuario != null)
                {
                    if (usuario.Status == StatusConta.Analisando)
                    {
                        return View("Analise", usuario.UserName);
                    }
                    else if (usuario.Status == StatusConta.reprovado)
                    {
                        return View("Reprovado", usuario.UserName);
                    }
                    else if(usuario.PrimeiroAcesso == true)
                    {
                        return View("RedefinirSenha", usuario);
                    }
                    else
                    {
                        PasswordHasher<Usuario> passwordHasher = new PasswordHasher<Usuario>();

                        if (passwordHasher.VerifyHashedPassword(usuario, usuario.PasswordHash, model.Senha) != PasswordVerificationResult.Failed)
                        {
                            await _usuarioRepositorio.LogarUsuario(usuario, false);
                            return RedirectToAction("Index"); 
                        }
                        else
                        {
                            ModelState.AddModelError("", "Email e/ou senha inválidos");
                            return View(model);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email e/ou senha inválidos");
                    return View(model);
                }
            }
            return View(model);
           
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _usuarioRepositorio.DeslogarUsuario();
            return RedirectToAction("Login");
        }

        public IActionResult Analise(string nome)
        {
            return View(nome);
        }
    }
}
