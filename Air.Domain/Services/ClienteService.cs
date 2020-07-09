using Air.Domain.Entities;
using Air.Domain.Interfaces.Repositories;
using Air.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Domain.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public ClienteService(IClienteRepository repository) : base(repository)
        {

        }
    }
}
