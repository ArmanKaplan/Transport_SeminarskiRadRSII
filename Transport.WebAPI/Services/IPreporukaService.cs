using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;

namespace Transport.WebAPI.Services
{
    public interface IPreporukaService
    {
        List<Model.Zahtjevi> PreporuciLokacijuIstovara();
    }
}
