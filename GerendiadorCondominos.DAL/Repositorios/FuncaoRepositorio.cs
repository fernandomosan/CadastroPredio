using GerenciadorCondominios.BLL.Models;
using GerendiadorCondominos.DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerendiadorCondominos.DAL.Repositorios
{
    public class FuncaoRepositorio : RepositorioGenerico<Funcao>, IFuncaoRepositorio
    {
        private readonly Contexto _contexto;

        public FuncaoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
