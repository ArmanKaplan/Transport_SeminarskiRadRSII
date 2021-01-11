using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileAplication.UWP;
using Transport.MobileApplication;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_UWP))]
namespace Transport.MobileAplication.UWP
{
    public class BaseUrl_UWP : IBaseUrl
    {
        public string Get()
        {
            return "ms-appx-web:///";
        }
    }
}