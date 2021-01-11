using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Transport.MobileAplication.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Transport.MobileAplication.App());
            Xamarin.FormsMaps.Init("kATd7jRdC8YKVUSHKyAM~b_qh9Suod0u6DvuMP0-uNQ~AiHeqpzOX88UfyMQcmeH6r69Pede9mAgZ_yEOVnTA8iiAmT2LBh3MKiSiDeM73fs");
        }
    }
}
