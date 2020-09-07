using Rickytech.Plataforma.CQRS.Domain.Entity;
using Rickytech.Plataforma.CQRS.Domain.Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
        Task<UsuarioEntityResponse> Create(UsuarioEntity usuarioEntity);
    }
}
