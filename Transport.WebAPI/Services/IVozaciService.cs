using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public interface IVozaciService
    {
        List<Model.Vozaci> Get(VozaciSearchRequest request);
        Model.Vozaci Insert(VozaciInsertRequest request);
        Model.Vozaci GetById(int id);
        Model.Vozaci Update(int id, VozaciUpdateRequest request);
        Model.Vozaci Authenticiraj(LoginSearchRequest request);


        Model.Vozaci GetLogovaniVozac();
        void SetLogovaniVozac(Model.Vozaci user);
    }
}
