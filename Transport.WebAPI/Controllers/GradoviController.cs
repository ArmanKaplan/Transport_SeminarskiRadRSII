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
    [AllowAnonymous]
    public class GradoviController : BaseController<Model.Gradovi, object>
    {
        public GradoviController(IService<Model.Gradovi, object> service) : base(service)
        {
        }
    }
}