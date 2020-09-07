using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Domain.Entity
{
    public class UsuarioEntity
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }
    }
}
