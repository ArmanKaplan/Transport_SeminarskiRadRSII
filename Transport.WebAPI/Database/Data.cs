using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transport.WebAPI.Database
{
    public class Data
    {
        public static void Seed(TransportContext transportContext)
        {
            transportContext.Database.Migrate();
        }
    }
}
