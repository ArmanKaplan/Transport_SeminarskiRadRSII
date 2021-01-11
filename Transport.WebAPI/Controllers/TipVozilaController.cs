using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    public class TipVozilaController : BaseController<Model.TipVozila, object>
    {
        public TipVozilaController(IService<TipVozila, object> service) : base(service)
        {
        }
    }
}
