using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Domain.Entity
{
    public class UsuarioEntity
    {
        public UsuarioEntity(string Nome, string Sobrenome, string Email)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Email = Email;
        }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Email { get; private set; }
    }
}
