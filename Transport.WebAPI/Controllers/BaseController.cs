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

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,TSearch>:ControllerBase
    {
        private readonly IService<T,TSearch> _service;
        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }
        [HttpGet]
        public List<T>Get([FromQuery]TSearch search)
        {
            return _service.Get(search);
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
