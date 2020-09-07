using Microsoft.EntityFrameworkCore.ChangeTracking;
using Rickytech.Plataforma.CQRS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Domain.Entity.Response
{
    public class UsuarioEntityResponse : UsuarioEntity
    {
        public UsuarioEntityResponse(string Nome, string Sobrenome, string Email)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Email = Email;
            this.Status = Status;
        }

        public UsuarioEntityResponse(string Nome, string Sobrenome)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Email = Email;
        }

        public string Status { get; set; }
    
    }
}
