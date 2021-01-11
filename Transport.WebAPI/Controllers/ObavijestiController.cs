using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    public class ObavijestiController : BaseCRUDController<Model.Obavijesti, object, ObavijestiPosaljiRequest, object>
    {
        public ObavijestiController(ICRUDService<Obavijesti, object, ObavijestiPosaljiRequest, object> service) : base(service)
        {
        }
    }
}
