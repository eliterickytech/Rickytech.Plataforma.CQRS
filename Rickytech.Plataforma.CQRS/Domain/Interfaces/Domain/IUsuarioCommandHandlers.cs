using Rickytech.Plataforma.CQRS.Domain.Command;
using Rickytech.Plataforma.CQRS.Domain.Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Domain.Interfaces.Domain
{
    public interface IUsuarioCommandHandlers
    {
        Task<string> Handle(UsuarioCreateCommand usuarioCreateCommand);
    }
}
