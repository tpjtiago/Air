using Air.Domain.Entities;
using Air.Domain.Interfaces.Repositories;
using Air.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
