using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;

namespace Transport.WebAPI.Services
{
    public interface IKlijentiService:ICRUDService<Model.Klijenti,KlijentiSearchRequest,KlijentiInsertRequest,KlijentiUpdateRequest>
    {
        
        Model.Klijenti Authenticiraj(LoginSearchRequest request);
        List<Model.Klijenti> Get(KlijentiSearchRequest request);
        Model.MyPaymentIntent CreatePaymentIntent(CreatePaymentIntentRequest request);
        Model.Klijenti GetLogovaniKlijent();
        void SetLogovaniKlijent(Model.Klijenti user);
    }
}
