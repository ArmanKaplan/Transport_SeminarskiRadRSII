using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    public class VozilaController : BaseCRUDController<Model.Vozila, VozilaSearchRequest, VozilaInsertRequest, VozilaUpdateRequest>
    {

        //public VozilaController(IVozaciService service) : base(service) { }
        public VozilaController(ICRUDService<Vozila, VozilaSearchRequest, VozilaInsertRequest, VozilaUpdateRequest> service) : base(service)
        {
        }
    }

}

