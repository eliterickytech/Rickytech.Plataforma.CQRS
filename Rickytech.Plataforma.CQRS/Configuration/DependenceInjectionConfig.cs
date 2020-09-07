using Microsoft.Extensions.DependencyInjection;
using Rickytech.Plataforma.CQRS.Domain.Handlers;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Domain;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Repository;
using Rickytech.Plataforma.CQRS.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Configuration
{
    public static class DependenceInjectionConfig
    {
        public static void AddDependenceInjectionConfig(this IServiceCollection services)
        {
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
            services.AddSingleton<IUsuarioCommandHandlers, UsuarioCommandHandlers>();
        }
    }
}
