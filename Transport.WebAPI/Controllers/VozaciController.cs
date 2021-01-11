using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Transport.Model;
using Microsoft.AspNetCore.Mvc;
using Transport.WebAPI.Services;
using Transport.WebAPI.Database;
using Microsoft.AspNetCore.Authorization;

namespace Transport.WebAPI.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VozaciController : ControllerBase
    {
        private readonly IVozaciService _service;
        public VozaciController(IVozaciService service)
        { _service = service; }
        [HttpGet]
        [Authorize(Roles = "Administrator,Vozac")]
        public ActionResult<List<Model.Vozaci>> Get([FromQuery]VozaciSearchRequest request)
        {

            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Vozaci GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Vozaci Insert(VozaciInsertRequest request)
        {
            
            return _service.Insert(request);
    }
        [Authorize(Roles = "Administrator,Vozac")]
        [HttpPut("{id}")]
        public Model.Vozaci Update(int id, [FromBody]VozaciUpdateRequest request)
        {
            return _service.Update(id, request);
        }


        [HttpGet("login")]
        [Authorize(Roles = "Vozac")]
        public Model.Vozaci Authenticiraj([FromQuery]LoginSearchRequest request)
        {
            return _service.Authenticiraj(request);
        }
    }




}