using AutoMapper;
using Rickytech.Plataforma.CQRS.Domain.Entity;
using Rickytech.Plataforma.CQRS.Domain.Entity.Response;

namespace Rickytech.Plataforma.CQRS.Domain.AutoMapper
{
    public class EntityToResponseMapping : Profile
    {
        public EntityToResponseMapping()
        {
            CreateMap<UsuarioEntity, UsuarioEntityResponse>();
        }
    }
}
