using Air.Application.DTO;
using Air.Application.Interfaces;
using Air.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Air.Service.API.Controllers
{
    public class PratoController : BaseController<Prato, PratoDTO>
    {
        public PratoController(IPratoApp app)
            : base(app)
        { }
    }
}
