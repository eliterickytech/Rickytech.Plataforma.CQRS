using AutoMapper;
using Rickytech.Plataforma.CQRS.Domain.Command;
using Rickytech.Plataforma.CQRS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Domain.AutoMapper
{
    public class DomainToEntityMapping : Profile
    {
        public DomainToEntityMapping() {
            CreateMap<UsuarioCreateCommand, UsuarioEntity>();
        }
    }
}
