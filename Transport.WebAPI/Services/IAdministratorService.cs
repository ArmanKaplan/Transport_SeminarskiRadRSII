using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;

namespace Transport.WebAPI.Services
{
    public interface IAdministratorService
    {
        Model.Administratori Authenticiraj(LoginSearchRequest request);
        List<Model.Administratori> Get(LoginSearchRequest request);
    }
}
