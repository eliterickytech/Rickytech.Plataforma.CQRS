using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rickytech.Plataforma.CQRS.Domain.Command;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Domain;

namespace Rickytech.Plataforma.CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioCommandHandlers usuarioCommandHandlers;
        public UsuarioController(IUsuarioCommandHandlers usuarioCommandHandlers) {
            this.usuarioCommandHandlers = usuarioCommandHandlers;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UsuarioCreateCommand usuarioCreateCommand)
        {
            var response = usuarioCommandHandlers.Handle(usuarioCreateCommand);
            return Ok(response);
        }
    }
}
