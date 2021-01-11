using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.MobileAplication.Models
{
    public enum MenuItemType
    {
        Početna,
        Zahtjevi,
        NoviZahtjev,
        AktivneVoznje,
        KorisnickiPodaci,
        Odjava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
