using GerendiadorCondominos.DAL.Intefaces;
using GerendiadorCondominos.DAL.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerendiadorCondominos.DAL
{
    public static class ConfiguracaoRepositoriosExtension
    {
        public static void ConfigurarRepositorio(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
        }
    }
}
