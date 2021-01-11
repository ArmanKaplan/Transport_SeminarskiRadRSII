using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PreporukaController : ControllerBase
    {
        protected IPreporukaService _service;

        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }
       
        [HttpGet("PreporuciLokacijuIstovara")]
        public ActionResult<List<Model.Zahtjevi>> PreporuciLokacijuIstovara()
        {
            return _service.PreporuciLokacijuIstovara();
        }
    }
}
