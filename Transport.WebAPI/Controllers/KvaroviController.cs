using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    public class KvaroviController : BaseCRUDController<Model.Kvarovi, KvaroviSearchRequest, KvaroviInsertRequest, object>
    {
        public KvaroviController(ICRUDService<Kvarovi, KvaroviSearchRequest, KvaroviInsertRequest, object> service) : base(service)
        {
        }
    }
}
