using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Air.Application.DTO;
using Air.Application.Interfaces;
using Air.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class PratoController : ControllerBase
    //{
    //}
    public class PratoController : BaseController<Prato, PratoDTO>
    {
        public PratoController(IPratoApp app)
            : base(app)
        { }
    }
}
