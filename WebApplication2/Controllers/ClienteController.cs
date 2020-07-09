using Air.Application.DTO;
using Air.Application.Interfaces;
using Air.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class ClienteController : BaseController<Cliente, ClienteDTO>
    {
        public ClienteController(IClienteApp app)
            : base(app)
        { }
    }
}
