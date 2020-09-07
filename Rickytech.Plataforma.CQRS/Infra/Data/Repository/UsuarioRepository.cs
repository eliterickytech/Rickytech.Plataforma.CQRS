using Microsoft.AspNetCore.JsonPatch.Internal;
using Rickytech.Plataforma.CQRS.Domain.Entity;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public List<UsuarioEntity> ListUsuarioEntities = new List<UsuarioEntity>();

        public async Task Create(UsuarioEntity usuarioEntity)
        {
            await Task.Run(() => ListUsuarioEntities.Add(usuarioEntity));
        }
    }
}
