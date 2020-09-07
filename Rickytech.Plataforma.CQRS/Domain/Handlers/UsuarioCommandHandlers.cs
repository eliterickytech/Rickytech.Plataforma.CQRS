using Rickytech.Plataforma.CQRS.Domain.Command;
using Rickytech.Plataforma.CQRS.Domain.Entity;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Domain;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Domain.Handlers
{
    public class UsuarioCommandHandlers : IUsuarioCommandHandlers
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioCommandHandlers(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public async Task<string> Handle(UsuarioCreateCommand usuarioCreateCommand)
        {
            var usuarioEntity = new UsuarioEntity
            (
                usuarioCreateCommand.Nome,
                usuarioCreateCommand.Sobrenome,
                usuarioCreateCommand.Email
            );

            await usuarioRepository.Create(usuarioEntity);
            return await Task.FromResult("Usuario cadastrado com sucesso");
        }
    }
}
