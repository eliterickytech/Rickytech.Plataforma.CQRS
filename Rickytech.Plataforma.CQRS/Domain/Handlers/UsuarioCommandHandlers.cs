using AutoMapper;
using MediatR;
using Rickytech.Plataforma.CQRS.Domain.Command;
using Rickytech.Plataforma.CQRS.Domain.Entity;
using Rickytech.Plataforma.CQRS.Domain.Entity.Response;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Domain;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Repository;
using Rickytech.Plataforma.CQRS.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Domain.Handlers
{
    public class UsuarioCommandHandlers : IRequestHandler<UsuarioCreateCommand, string>
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public UsuarioCommandHandlers(IUsuarioRepository usuarioRepository, IMapper mapper, IMediator mediator)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
            this.mediator = mediator;
        }

        public async Task<string> Handle(UsuarioCreateCommand usuarioCreateCommand, CancellationToken cancellationToken )
        {
            // Mapeamento da classe UsuarioCreateCommand para UsuarioEntity
            var usuarioEntity = mapper.Map<UsuarioEntity>(usuarioCreateCommand);

            var retornoRepository = await usuarioRepository.Create(usuarioEntity);
            
            await mediator.Publish(new UsuarioActionNotification
            {
                Nome = retornoRepository.Nome,
                Sobrenome = retornoRepository.Sobrenome,
                Email = retornoRepository.Email,
                Acao = ActionNotification.Criado
            });
            return await Task.FromResult(retornoRepository.Status);
        }
    }
}
