using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;

namespace Transport.WebAPI.Database
{
    public partial class TransportContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administratori>().HasData(new WebAPI.Database.Administratori
            {
              AdministratorId=1,
              KorisnickoIme="Administrator",
              Lozinka="admin"
              
             
            });
            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi
            {
              GradId=10,
              Naziv="Stolac"
            });
            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi
            {
                GradId = 2,
                Naziv = "Mostar"
            });
            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi
            {
                GradId = 3,
                Naziv = "Sarajevo"
            });
            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi
            {
                GradId = 4,
                Naziv = "Tuzla"
            });

            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi
            {
                GradId = 5,
                Naziv = "Zenica"
            });
            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi
            {
                GradId = 6,
                Naziv = "Kakanj"
            });
            modelBuilder.Entity<TipoviVozila>().HasData(new WebAPI.Database.TipoviVozila
            {
                TipVozilaId = 1,
                Naziv = "Sa ceradom"
            });
            modelBuilder.Entity<TipoviVozila>().HasData(new WebAPI.Database.TipoviVozila
            {
                TipVozilaId = 2,
                Naziv = "Bez cerade"
            });
            modelBuilder.Entity<TipoviVozila>().HasData(new WebAPI.Database.TipoviVozila
            {
                TipVozilaId = 3,
                Naziv = "Šlepa"
            });
            modelBuilder.Entity<Vozila>().HasData(new WebAPI.Database.Vozila
            {
                VoziloId = 1,
                TipVozilaId = 1,
                Boja = "Crvena",
                GodinaProizvodnje = 2019,
                Kilovati = 230,
                Marka = "Mercedes-Benz",
                Model = "Actros",
                RegistracijskeOznake = "TN0-K-2MN"

            });
            modelBuilder.Entity<Vozila>().HasData(new WebAPI.Database.Vozila
            {
                VoziloId = 2,
                TipVozilaId = 2,
                Boja = "Zelena",
                GodinaProizvodnje = 2018,
                Kilovati = 250,
                Marka = "Mercedes-Benz",
                Model = "Actros",
                RegistracijskeOznake = "SG0-N-1KN"


            });
            modelBuilder.Entity<TipoviRoba>().HasData(new WebAPI.Database.TipoviRoba
            {
                TipRobeId = 1,
                Naziv = "Lomljiva"

            });
            modelBuilder.Entity<TipoviRoba>().HasData(new WebAPI.Database.TipoviRoba
            {
                TipRobeId = 2,
                Naziv = "Zapaljiva"

            });
            modelBuilder.Entity<TipoviRoba>().HasData(new WebAPI.Database.TipoviRoba
            {
                TipRobeId = 3,
                Naziv = "Prioritetna"

            });
            modelBuilder.Entity<TipoviRoba>().HasData(new WebAPI.Database.TipoviRoba
            {
                TipRobeId = 4,
                Naziv = "Ostalo"

            });
            modelBuilder.Entity<Klijenti>().HasData(new WebAPI.Database.Klijenti
            {

                KlijentId = 1,
                KorisnickoIme = "Klijent",
                LozinkaSalt = "FNECPo7it/SExHjE7fzmew==",
                LozinkaHash = "7bR9xZtoXzV010VzMhJ18P+HWt4=",
                GradId = 10,
                Firma = "MM-Comerce",
                Email = "klijent@gmail.com",
                Ime = "Arman",
                Prezime = "Kaplan",
                Telefon = "062-437-836",

            });
            modelBuilder.Entity<Vozaci>().HasData(new WebAPI.Database.Vozaci
            {

                VozacId = 1,
                KorisnickoIme = "Vozac",
                LozinkaSalt = "m7sQeHGBYf+oZM0hBN3Eqw==",
                LozinkaHash = "vIQcy12pFXZuN1vs8OyefzVyd5A=",
                GradId = 10,
                Ime = "Arman",
                Prezime = "Kaplan",
                VoziloId = 2,
                Adresa = "Rivine bb",
                GodineIskustva = 2,
                Jmbg = "1899996153759",
                MjestoRodjenja = "Mostar"
                


            });
            modelBuilder.Entity<Vozaci>().HasData(new WebAPI.Database.Vozaci
            {

                VozacId = 2,
                KorisnickoIme = "Vozac2",
                LozinkaSalt = "m7sQeHGBYf+oZM0hBN3Eqw==",
                LozinkaHash = "vIQcy12pFXZuN1vs8OyefzVyd5A=",
                GradId = 10,
                Ime = "Sakib",
                Prezime = "Hodzić",
                VoziloId = 1,
                Adresa = "Krajsina bb",
                GodineIskustva = 4,
                Jmbg = "189423615559",
                MjestoRodjenja = "Sarajevo"



            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {
                
                DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaIstovara = "Mostar, Maršala Tita 94",
                LokacijaUtovara = "Mostar, Bišće polje",
                Napomena = "Molim vas da budete tačni",
                Obradjen = false,
                Odbijen = false,
                TipRobeId = 1,
                TipVozilaId = 1,
                Uplaceno = false,
                ZahtjevId = 1,
                VrstaRobe = "Tkanina",
                
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaIstovara = "Sarajevo, Ul. Šenoina br. 1",
                LokacijaUtovara = "Mostar, Bišće polje",
                Napomena = "Molim vas da budete tačni",
                Obradjen = false,
                Odbijen = false,
                TipRobeId = 1,
                TipVozilaId = 1,
                Uplaceno = false,
                ZahtjevId = 2,
                VrstaRobe = "Porculan"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaIstovara = "Sarajevo, Ul. Šenoina br. 1",
                LokacijaUtovara = "Stolac, Humska bb",
                Napomena = "Molim vas da budete tačni",
                Obradjen = false,
                Odbijen = false,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 3,
                VrstaRobe = "Drva"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaIstovara = "Sarajevo, Ul. Šenoina br. 1",
                LokacijaUtovara = "Stolac, Humska bb",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = false,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 4,
                VrstaRobe = "Drva"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaUtovara = "Sarajevo, Ul. Šenoina br. 1",
                LokacijaIstovara = "Stolac, Humska bb",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = false,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 5,
                VrstaRobe = "Drva"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaUtovara = "Ljubinje, Bančići",
                LokacijaIstovara = "Stolac, Humska bb",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = false,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 8,
                VrstaRobe = "Drva"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaUtovara = "Tuzla, Titova",
                LokacijaIstovara = "Bihac, Nade Kalić",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = true,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 6,
                VrstaRobe = "Drva"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaUtovara = "Zvornik, Divič",
                LokacijaIstovara = "Trebinje, Pridovci",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = true,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 7,
                VrstaRobe = "Drva"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {
               
            DatumTransporta = DateTime.Now,
                KlijentId = 1,
                LokacijaUtovara = "Kladanj, Buševo",
                LokacijaIstovara = "Trebinje, Pridovci",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = false,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 9,
                VrstaRobe = "Pelet"
            });
           modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {
                
        DatumTransporta = new DateTime(2018, 6, 1, 7, 47, 0),
                KlijentId = 1,
                LokacijaUtovara = "Srebrenica, Buševo",
                LokacijaIstovara = "Gacko, Milici",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = false,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 11,
                VrstaRobe = "Pelet"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = new DateTime(2019, 6, 1, 7, 47, 0),
                KlijentId = 1,
                LokacijaUtovara = "Stolac, Rivine bb",
                LokacijaIstovara = "Domanovići, Pridovci",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = false,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 12,
                VrstaRobe = "Građa"
            });
            modelBuilder.Entity<Zahtjevi>().HasData(new WebAPI.Database.Zahtjevi
            {

                DatumTransporta = new DateTime(2020, 6, 1, 7, 47, 0),
                KlijentId = 1,
                LokacijaUtovara = "Jablanica, Buševo",
                LokacijaIstovara = "Nevesinje, Pridovci",
                Napomena = "Molim vas da budete tačni",
                Obradjen = true,
                Odbijen = false,
                TipRobeId = 2,
                TipVozilaId = 2,
                Uplaceno = false,
                ZahtjevId = 13,
                VrstaRobe = "Pelet"
            });
            modelBuilder.Entity<Voznje>().HasData(new WebAPI.Database.Voznje
            {
                Cijena = 554,
                Kilometraza = 231,
                Napomena = "Naravno",
                Ocijenjen = false,
                VoznjaId = 1,
                VozacId = 1,
                Odgovoren = true,
                Prihvacen = true,
                Zapoceto = true,
                ZahtjevId = 1,
                Zavrsen = false,

            });
            modelBuilder.Entity<Voznje>().HasData(new WebAPI.Database.Voznje
            {
                Cijena = 554,
                Kilometraza = 231,
                Napomena = "Naravno",
                Ocijenjen = false,
                VoznjaId = 2,
                VozacId = 1,
                Odgovoren = true,
                Prihvacen = true,
                Zapoceto = true,
                ZahtjevId = 5,
                Zavrsen = true,

            });
            modelBuilder.Entity<Voznje>().HasData(new WebAPI.Database.Voznje
            {
                Cijena = 554,
                Kilometraza = 231,
                Napomena = "Naravno",
                Ocijenjen = false,
                VoznjaId = 4,
                VozacId = 2,
                Odgovoren = true,
                Prihvacen = true,
                Zapoceto = true,
                ZahtjevId = 9,
                Zavrsen = false,

            });
            modelBuilder.Entity<Voznje>().HasData(new WebAPI.Database.Voznje
            {
                Cijena = 159,
                Kilometraza = 45,
                Napomena = "Naravno",
                Ocijenjen = true,
                VoznjaId = 3,
                VozacId = 1,
                Odgovoren = true,
                Prihvacen = true,
                Zapoceto = true,
                ZahtjevId = 8,
                Zavrsen = true,

            });
            modelBuilder.Entity<Voznje>().HasData(new WebAPI.Database.Voznje
            {
                Cijena = 330,
                Kilometraza = 125,
                Napomena = "Naravno",
                Ocijenjen = true,
                Ocjena=5,
                VoznjaId = 13,
                VozacId = 1,
                Odgovoren = true,
                Prihvacen = true,
                Zapoceto = true,
                ZahtjevId = 11,
                Zavrsen = true,

            });
            modelBuilder.Entity<Voznje>().HasData(new WebAPI.Database.Voznje
            {
                Cijena = 400,
                Kilometraza = 125,
                Napomena = "Naravno",
                Ocijenjen = true,
                Ocjena = 5,
                VoznjaId = 14,
                VozacId = 2,
                Odgovoren = true,
                Prihvacen = true,
                Zapoceto = true,
                ZahtjevId = 12,
                Zavrsen = true,

            });
            modelBuilder.Entity<Voznje>().HasData(new WebAPI.Database.Voznje
            {
                Cijena = 541,
                Kilometraza = 225,
                Napomena = "Naravno",
                Ocijenjen = true,
                Ocjena = 3,
                VoznjaId = 15,
                VozacId = 1,
                Odgovoren = true,
                Prihvacen = true,
                Zapoceto = true,
                ZahtjevId = 13,
                Zavrsen = true,

            });
            modelBuilder.Entity<Kvarovi>().HasData(new WebAPI.Database.Kvarovi
            {
                KvarId=1,
                Lokacija="Mostar, Bulevar",
                Opis="Vozilo se ugasilo u voznji, ne moze se ponovno pokrenuti.",
                Prioritetno=true,
                VoznjaId=1,
                Lat="43.33373",
                Lng ="17.81410"
            });
            modelBuilder.Entity<Obavijesti>().HasData(new WebAPI.Database.Obavijesti
            {
                ObavijestId = 1,
                Tekst = "Molim te drzi se dogovora.",
                VoznjaId = 1,
                Datum =DateTime.Now.Date

            });
            modelBuilder.Entity<Lociranja>().HasData(new WebAPI.Database.Lociranja
            {
              AdministratorId=1,
              KlijentId=null,
              LociranjeId=1,
              Odogovoreno=true,
              Prihvaceno=true,
              VoznjaId=1,
              Lat= "43.33373",
              Lng = "17.81410"


            });
            modelBuilder.Entity<Lociranja>().HasData(new WebAPI.Database.Lociranja
            {
                AdministratorId = null,
                KlijentId = 1,
                LociranjeId = 2,
                Odogovoreno = true,
                Prihvaceno = true,
                VoznjaId = 1,
                Lat = "43.33373",
                Lng = "17.81410"


            });

        }
    }
}
