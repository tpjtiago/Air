using Air.Application.DTO;
using Air.Application.Interfaces;
using Air.Domain.Entities;
using Air.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Application.Services
{
    public class ClienteApp : BaseServiceApp<Cliente, ClienteDTO>, IClienteApp
    {
      public ClienteApp(IMapper iMapper, IClienteService service): base(iMapper, service)
        {

        }
    }
}
