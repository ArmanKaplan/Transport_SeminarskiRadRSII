using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;

namespace Transport.WebAPI.Services
{
   public interface ILociranjaService : ICRUDService<Model.Lociranja, LociranjaSerachRequest, LociranjaInsertRequest, LociranjaUpdateRequest>
    {
    }
}
