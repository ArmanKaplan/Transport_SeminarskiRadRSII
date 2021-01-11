using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.MobileAplication.Models.Vozaci
{
    public enum MenuItemType1
    {
        Pocetna,
        MojeVoznje,
        Odjava,
    }
    public class HomeMenuItem1
    {
        public MenuItemType1 Id { get; set; }

        public string Title { get; set; }
    }
}
