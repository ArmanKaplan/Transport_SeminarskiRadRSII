using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Transport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AdministratoriController : ControllerBase
    {
        protected IAdministratorService _service;

        public AdministratoriController(IAdministratorService service)
        {
            _service = service;
        }
        [HttpPost("login")]
        public Model.Administratori Authenticiraj(LoginSearchRequest request)
        {
            return _service.Authenticiraj(request);
        }
        [HttpGet]
        public ActionResult<List<Model.Administratori>> Get([FromQuery] LoginSearchRequest request)
        {

            return _service.Get(request);
        }

    }
}
