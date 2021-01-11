using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class ZahtjeviUplataIzvrsenaRequest
    {
        public string PaymentMethodId { get; set; }
        public int ZahtjevId { get; set; }
    }
}
