﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoCadastroPrédio.Extensions
{
    public static class ConfiguracaoIdentityExtension
    {
        public static void ConfiguraNomeUsuario(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(opcoes =>
            {
                opcoes.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-. _ @+";
                opcoes.User.RequireUniqueEmail = true;
            });
        }

        public static void ConfiguraSenhaUsuario(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(opcoes =>
            {
                opcoes.Password.RequireDigit = true;
                opcoes.Password.RequireLowercase = true;
                opcoes.Password.RequiredLength = 8;
                opcoes.Password.RequireNonAlphanumeric = true;
                opcoes.Password.RequireUppercase = true;
                opcoes.Password.RequiredUniqueChars = 0;
            });
        }
    }
}
