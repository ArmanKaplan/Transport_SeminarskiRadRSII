﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.Views.Klijenti;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegisterLabel_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistracijaPage();
        }
    }
}