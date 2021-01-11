using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transport.Model;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    public class TipRobeController : BaseController<Model.TipoviRoba, object>
    {
        public TipRobeController(IService<TipoviRoba, object> service) : base(service)
        {
        }
    }
}
