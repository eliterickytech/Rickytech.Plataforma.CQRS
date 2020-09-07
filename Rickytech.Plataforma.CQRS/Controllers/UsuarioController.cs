using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rickytech.Plataforma.CQRS.Domain.Command;

namespace Rickytech.Plataforma.CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : APIController
    {
        private readonly IMediator mediator;

        public UsuarioController(IMediator mediator) {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<object> Create([FromBody] UsuarioCreateCommand usuarioCreateCommand)
        {
            return await mediator.Send(usuarioCreateCommand);
        }
    }
}
