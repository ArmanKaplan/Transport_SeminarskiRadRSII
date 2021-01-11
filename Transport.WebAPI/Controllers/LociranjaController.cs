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

    public class LociranjaController : BaseCRUDController<Model.Lociranja, LociranjaSerachRequest, LociranjaInsertRequest, LociranjaUpdateRequest>
    {
        public LociranjaController(ICRUDService<Lociranja, LociranjaSerachRequest, LociranjaInsertRequest, LociranjaUpdateRequest> service) : base(service)
        {
        }
    }
}
