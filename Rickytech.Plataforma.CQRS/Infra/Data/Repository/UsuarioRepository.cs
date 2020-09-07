using AutoMapper;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Rickytech.Plataforma.CQRS.Domain.Entity;
using Rickytech.Plataforma.CQRS.Domain.Entity.Response;
using Rickytech.Plataforma.CQRS.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IMapper mapper; 

        public UsuarioRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<UsuarioEntityResponse> Create(UsuarioEntity usuarioEntity)
        {
            var entityReponse = mapper.Map<UsuarioEntityResponse>(usuarioEntity);
            entityReponse.Status = "Cadastrado com Sucesso";
            return await Task.FromResult(entityReponse);
        }
    }
}
