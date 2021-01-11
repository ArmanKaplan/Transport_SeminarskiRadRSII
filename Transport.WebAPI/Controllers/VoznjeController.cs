using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    public class VoznjeController : BaseCRUDController<Model.Voznje, VoznjeSearchRequest, VoznjeInsertRequest, VoznjeUpdateRequest>
    {
        public VoznjeController(ICRUDService<Voznje, VoznjeSearchRequest, VoznjeInsertRequest, VoznjeUpdateRequest> service) : base(service)
        {
        }
    }
}
