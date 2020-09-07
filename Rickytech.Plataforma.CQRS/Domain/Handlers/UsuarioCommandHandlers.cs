using AutoMapper;
using Rickytech.Plataforma.CQRS.Domain.Command;
using Rickytech.Plataforma.CQRS.Domain.Entity;
using Rickytech.Plataforma.CQRS.Domain.Entity.Response;
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
        private readonly IMapper mapper;

        public UsuarioCommandHandlers(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }

        public async Task<string> Handle(UsuarioCreateCommand usuarioCreateCommand)
        {
            // Mapeamento da classe UsuarioCreateCommand para UsuarioEntity
            var usuarioEntity = mapper.Map<UsuarioEntity>(usuarioCreateCommand);

            var retorno = await usuarioRepository.Create(usuarioEntity);
            return await Task.FromResult(retorno.Status);
        }
    }
}
