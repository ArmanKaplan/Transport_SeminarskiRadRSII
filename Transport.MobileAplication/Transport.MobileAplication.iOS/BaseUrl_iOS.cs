using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Transport.MobileAplication.iOS;
using Transport.MobileApplication;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_iOS))]
namespace Transport.MobileAplication.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}
