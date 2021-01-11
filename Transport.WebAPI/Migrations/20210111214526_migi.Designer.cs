﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Migrations
{
    [DbContext(typeof(TransportContext))]
    [Migration("20210111214526_migi")]
    partial class migi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Transport.WebAPI.Database.Administratori", b =>
                {
                    b.Property<int>("AdministratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AdministratorID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AdministratorId");

                    b.ToTable("Administratori");

                    b.HasData(
                        new
                        {
                            AdministratorId = 1,
                            KorisnickoIme = "Administrator",
                            Lozinka = "admin"
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Gradovi", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GradID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("GradId");

                    b.ToTable("Gradovi");

                    b.HasData(
                        new
                        {
                            GradId = 10,
                            Naziv = "Stolac"
                        },
                        new
                        {
                            GradId = 2,
                            Naziv = "Mostar"
                        },
                        new
                        {
                            GradId = 3,
                            Naziv = "Sarajevo"
                        },
                        new
                        {
                            GradId = 4,
                            Naziv = "Tuzla"
                        },
                        new
                        {
                            GradId = 5,
                            Naziv = "Zenica"
                        },
                        new
                        {
                            GradId = 6,
                            Naziv = "Kakanj"
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Klijenti", b =>
                {
                    b.Property<int>("KlijentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KlijentID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("GradId")
                        .HasColumnName("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("KlijentId");

                    b.HasIndex("GradId");

                    b.ToTable("Klijenti");

                    b.HasData(
                        new
                        {
                            KlijentId = 1,
                            Email = "klijent@gmail.com",
                            Firma = "MM-Comerce",
                            GradId = 10,
                            Ime = "Arman",
                            KorisnickoIme = "Klijent",
                            LozinkaHash = "7bR9xZtoXzV010VzMhJ18P+HWt4=",
                            LozinkaSalt = "FNECPo7it/SExHjE7fzmew==",
                            Prezime = "Kaplan",
                            Telefon = "062-437-836"
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Kvarovi", b =>
                {
                    b.Property<int>("KvarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KvarID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lokacija")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Prioritetno")
                        .HasColumnType("bit");

                    b.Property<int>("VoznjaId")
                        .HasColumnName("VoznjaID")
                        .HasColumnType("int");

                    b.HasKey("KvarId");

                    b.HasIndex("VoznjaId");

                    b.ToTable("Kvarovi");

                    b.HasData(
                        new
                        {
                            KvarId = 1,
                            Lat = "43.33373",
                            Lng = "17.81410",
                            Lokacija = "Mostar, Bulevar",
                            Opis = "Vozilo se ugasilo u voznji, ne moze se ponovno pokrenuti.",
                            Prioritetno = true,
                            VoznjaId = 1
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Lociranja", b =>
                {
                    b.Property<int>("LociranjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LociranjeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdministratorId")
                        .HasColumnName("AdministratorID")
                        .HasColumnType("int");

                    b.Property<int?>("KlijentId")
                        .HasColumnName("KlijentID")
                        .HasColumnType("int");

                    b.Property<string>("Lat")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Lng")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("Odogovoreno")
                        .HasColumnType("bit");

                    b.Property<bool>("Prihvaceno")
                        .HasColumnType("bit");

                    b.Property<int>("VoznjaId")
                        .HasColumnName("VoznjaID")
                        .HasColumnType("int");

                    b.HasKey("LociranjeId");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("VoznjaId");

                    b.ToTable("Lociranja");

                    b.HasData(
                        new
                        {
                            LociranjeId = 1,
                            AdministratorId = 1,
                            Lat = "43.33373",
                            Lng = "17.81410",
                            Odogovoreno = true,
                            Prihvaceno = true,
                            VoznjaId = 1
                        },
                        new
                        {
                            LociranjeId = 2,
                            KlijentId = 1,
                            Lat = "43.33373",
                            Lng = "17.81410",
                            Odogovoreno = true,
                            Prihvaceno = true,
                            VoznjaId = 1
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Obavijesti", b =>
                {
                    b.Property<int>("ObavijestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ObavijestID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("VoznjaId")
                        .HasColumnName("VoznjaID")
                        .HasColumnType("int");

                    b.HasKey("ObavijestId");

                    b.HasIndex("VoznjaId");

                    b.ToTable("Obavijesti");

                    b.HasData(
                        new
                        {
                            ObavijestId = 1,
                            Datum = new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Tekst = "Molim te drzi se dogovora.",
                            VoznjaId = 1
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.TipoviRoba", b =>
                {
                    b.Property<int>("TipRobeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TipRobeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("TipRobeId");

                    b.ToTable("TipoviRoba");

                    b.HasData(
                        new
                        {
                            TipRobeId = 1,
                            Naziv = "Lomljiva"
                        },
                        new
                        {
                            TipRobeId = 2,
                            Naziv = "Zapaljiva"
                        },
                        new
                        {
                            TipRobeId = 3,
                            Naziv = "Prioritetna"
                        },
                        new
                        {
                            TipRobeId = 4,
                            Naziv = "Ostalo"
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.TipoviVozila", b =>
                {
                    b.Property<int>("TipVozilaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TipVozilaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("TipVozilaId");

                    b.ToTable("TipoviVozila");

                    b.HasData(
                        new
                        {
                            TipVozilaId = 1,
                            Naziv = "Sa ceradom"
                        },
                        new
                        {
                            TipVozilaId = 2,
                            Naziv = "Bez cerade"
                        },
                        new
                        {
                            TipVozilaId = 3,
                            Naziv = "Šlepa"
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Vozaci", b =>
                {
                    b.Property<int>("VozacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VozacID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("GodineIskustva")
                        .HasColumnType("int");

                    b.Property<int>("GradId")
                        .HasColumnName("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Jmbg")
                        .IsRequired()
                        .HasColumnName("JMBG")
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("MjestoRodjenja")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("VoziloId")
                        .HasColumnName("VoziloID")
                        .HasColumnType("int");

                    b.HasKey("VozacId");

                    b.HasIndex("GradId");

                    b.HasIndex("VoziloId");

                    b.ToTable("Vozaci");

                    b.HasData(
                        new
                        {
                            VozacId = 1,
                            Adresa = "Rivine bb",
                            GodineIskustva = 2,
                            GradId = 10,
                            Ime = "Arman",
                            Jmbg = "1899996153759",
                            KorisnickoIme = "Vozac",
                            LozinkaHash = "vIQcy12pFXZuN1vs8OyefzVyd5A=",
                            LozinkaSalt = "m7sQeHGBYf+oZM0hBN3Eqw==",
                            MjestoRodjenja = "Mostar",
                            Prezime = "Kaplan",
                            VoziloId = 2
                        },
                        new
                        {
                            VozacId = 2,
                            Adresa = "Krajsina bb",
                            GodineIskustva = 4,
                            GradId = 10,
                            Ime = "Sakib",
                            Jmbg = "189423615559",
                            KorisnickoIme = "Vozac2",
                            LozinkaHash = "vIQcy12pFXZuN1vs8OyefzVyd5A=",
                            LozinkaSalt = "m7sQeHGBYf+oZM0hBN3Eqw==",
                            MjestoRodjenja = "Sarajevo",
                            Prezime = "Hodzić",
                            VoziloId = 1
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Vozila", b =>
                {
                    b.Property<int>("VoziloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VoziloID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Boja")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("GodinaProizvodnje")
                        .HasColumnType("int");

                    b.Property<int>("Kilovati")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RegistracijskeOznake")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("TipVozilaId")
                        .HasColumnName("TipVozilaID")
                        .HasColumnType("int");

                    b.HasKey("VoziloId");

                    b.HasIndex("TipVozilaId");

                    b.ToTable("Vozila");

                    b.HasData(
                        new
                        {
                            VoziloId = 1,
                            Boja = "Crvena",
                            GodinaProizvodnje = 2019,
                            Kilovati = 230,
                            Marka = "Mercedes-Benz",
                            Model = "Actros",
                            RegistracijskeOznake = "TN0-K-2MN",
                            TipVozilaId = 1
                        },
                        new
                        {
                            VoziloId = 2,
                            Boja = "Zelena",
                            GodinaProizvodnje = 2018,
                            Kilovati = 250,
                            Marka = "Mercedes-Benz",
                            Model = "Actros",
                            RegistracijskeOznake = "SG0-N-1KN",
                            TipVozilaId = 2
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Voznje", b =>
                {
                    b.Property<int>("VoznjaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VoznjaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("Kilometraza")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<bool>("Ocijenjen")
                        .HasColumnType("bit");

                    b.Property<int?>("Ocjena")
                        .HasColumnType("int");

                    b.Property<bool>("Odgovoren")
                        .HasColumnType("bit");

                    b.Property<bool>("Prihvacen")
                        .HasColumnType("bit");

                    b.Property<int>("VozacId")
                        .HasColumnName("VozacID")
                        .HasColumnType("int");

                    b.Property<int>("ZahtjevId")
                        .HasColumnName("ZahtjevID")
                        .HasColumnType("int");

                    b.Property<bool>("Zapoceto")
                        .HasColumnType("bit");

                    b.Property<bool>("Zavrsen")
                        .HasColumnType("bit");

                    b.HasKey("VoznjaId")
                        .HasName("PK_Odgovori");

                    b.HasIndex("VozacId");

                    b.HasIndex("ZahtjevId");

                    b.ToTable("Voznje");

                    b.HasData(
                        new
                        {
                            VoznjaId = 1,
                            Cijena = 554m,
                            Kilometraza = 231,
                            Napomena = "Naravno",
                            Ocijenjen = false,
                            Odgovoren = true,
                            Prihvacen = true,
                            VozacId = 1,
                            ZahtjevId = 1,
                            Zapoceto = true,
                            Zavrsen = false
                        },
                        new
                        {
                            VoznjaId = 2,
                            Cijena = 554m,
                            Kilometraza = 231,
                            Napomena = "Naravno",
                            Ocijenjen = false,
                            Odgovoren = true,
                            Prihvacen = true,
                            VozacId = 1,
                            ZahtjevId = 5,
                            Zapoceto = true,
                            Zavrsen = true
                        },
                        new
                        {
                            VoznjaId = 4,
                            Cijena = 554m,
                            Kilometraza = 231,
                            Napomena = "Naravno",
                            Ocijenjen = false,
                            Odgovoren = true,
                            Prihvacen = true,
                            VozacId = 2,
                            ZahtjevId = 9,
                            Zapoceto = true,
                            Zavrsen = false
                        },
                        new
                        {
                            VoznjaId = 3,
                            Cijena = 159m,
                            Kilometraza = 45,
                            Napomena = "Naravno",
                            Ocijenjen = true,
                            Odgovoren = true,
                            Prihvacen = true,
                            VozacId = 1,
                            ZahtjevId = 8,
                            Zapoceto = true,
                            Zavrsen = true
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Zahtjevi", b =>
                {
                    b.Property<int>("ZahtjevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ZahtjevID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumTransporta")
                        .HasColumnType("date");

                    b.Property<int>("KlijentId")
                        .HasColumnName("KlijentID")
                        .HasColumnType("int");

                    b.Property<string>("LokacijaIstovara")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LokacijaUtovara")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<bool>("Obradjen")
                        .HasColumnType("bit");

                    b.Property<bool>("Odbijen")
                        .HasColumnType("bit");

                    b.Property<int>("TipRobeId")
                        .HasColumnName("TipRobeID")
                        .HasColumnType("int");

                    b.Property<int>("TipVozilaId")
                        .HasColumnName("TipVozilaID")
                        .HasColumnType("int");

                    b.Property<string>("Transakcija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Uplaceno")
                        .HasColumnType("bit");

                    b.Property<string>("VrstaRobe")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ZahtjevId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("TipRobeId");

                    b.HasIndex("TipVozilaId");

                    b.ToTable("Zahtjevi");

                    b.HasData(
                        new
                        {
                            ZahtjevId = 1,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 363, DateTimeKind.Local).AddTicks(4957),
                            KlijentId = 1,
                            LokacijaIstovara = "Mostar, Maršala Tita 94",
                            LokacijaUtovara = "Mostar, Bišće polje",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = false,
                            Odbijen = false,
                            TipRobeId = 1,
                            TipVozilaId = 1,
                            Uplaceno = false,
                            VrstaRobe = "Tkanina"
                        },
                        new
                        {
                            ZahtjevId = 2,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 368, DateTimeKind.Local).AddTicks(8798),
                            KlijentId = 1,
                            LokacijaIstovara = "Sarajevo, Ul. Šenoina br. 1",
                            LokacijaUtovara = "Mostar, Bišće polje",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = false,
                            Odbijen = false,
                            TipRobeId = 1,
                            TipVozilaId = 1,
                            Uplaceno = false,
                            VrstaRobe = "Porculan"
                        },
                        new
                        {
                            ZahtjevId = 3,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 368, DateTimeKind.Local).AddTicks(9196),
                            KlijentId = 1,
                            LokacijaIstovara = "Sarajevo, Ul. Šenoina br. 1",
                            LokacijaUtovara = "Stolac, Humska bb",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = false,
                            Odbijen = false,
                            TipRobeId = 2,
                            TipVozilaId = 2,
                            Uplaceno = false,
                            VrstaRobe = "Drva"
                        },
                        new
                        {
                            ZahtjevId = 4,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 368, DateTimeKind.Local).AddTicks(9289),
                            KlijentId = 1,
                            LokacijaIstovara = "Sarajevo, Ul. Šenoina br. 1",
                            LokacijaUtovara = "Stolac, Humska bb",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = true,
                            Odbijen = false,
                            TipRobeId = 2,
                            TipVozilaId = 2,
                            Uplaceno = false,
                            VrstaRobe = "Drva"
                        },
                        new
                        {
                            ZahtjevId = 5,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 368, DateTimeKind.Local).AddTicks(9372),
                            KlijentId = 1,
                            LokacijaIstovara = "Stolac, Humska bb",
                            LokacijaUtovara = "Sarajevo, Ul. Šenoina br. 1",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = true,
                            Odbijen = false,
                            TipRobeId = 2,
                            TipVozilaId = 2,
                            Uplaceno = false,
                            VrstaRobe = "Drva"
                        },
                        new
                        {
                            ZahtjevId = 8,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 368, DateTimeKind.Local).AddTicks(9462),
                            KlijentId = 1,
                            LokacijaIstovara = "Stolac, Humska bb",
                            LokacijaUtovara = "Ljubinje, Bančići",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = true,
                            Odbijen = false,
                            TipRobeId = 2,
                            TipVozilaId = 2,
                            Uplaceno = false,
                            VrstaRobe = "Drva"
                        },
                        new
                        {
                            ZahtjevId = 6,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 368, DateTimeKind.Local).AddTicks(9619),
                            KlijentId = 1,
                            LokacijaIstovara = "Bihac, Nade Kalić",
                            LokacijaUtovara = "Tuzla, Titova",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = true,
                            Odbijen = true,
                            TipRobeId = 2,
                            TipVozilaId = 2,
                            Uplaceno = false,
                            VrstaRobe = "Drva"
                        },
                        new
                        {
                            ZahtjevId = 7,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 368, DateTimeKind.Local).AddTicks(9710),
                            KlijentId = 1,
                            LokacijaIstovara = "Trebinje, Pridovci",
                            LokacijaUtovara = "Zvornik, Divič",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = true,
                            Odbijen = true,
                            TipRobeId = 2,
                            TipVozilaId = 2,
                            Uplaceno = false,
                            VrstaRobe = "Drva"
                        },
                        new
                        {
                            ZahtjevId = 9,
                            DatumTransporta = new DateTime(2021, 1, 11, 22, 45, 25, 368, DateTimeKind.Local).AddTicks(9794),
                            KlijentId = 1,
                            LokacijaIstovara = "Trebinje, Pridovci",
                            LokacijaUtovara = "Kladanj, Buševo",
                            Napomena = "Molim vas da budete tačni",
                            Obradjen = true,
                            Odbijen = false,
                            TipRobeId = 2,
                            TipVozilaId = 2,
                            Uplaceno = false,
                            VrstaRobe = "Pelet"
                        });
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Klijenti", b =>
                {
                    b.HasOne("Transport.WebAPI.Database.Gradovi", "Grad")
                        .WithMany("Klijenti")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK_Klijenti_Gradovi")
                        .IsRequired();
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Kvarovi", b =>
                {
                    b.HasOne("Transport.WebAPI.Database.Voznje", "Voznja")
                        .WithMany("Kvarovi")
                        .HasForeignKey("VoznjaId")
                        .HasConstraintName("FK_Kvarovi_Voznje")
                        .IsRequired();
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Lociranja", b =>
                {
                    b.HasOne("Transport.WebAPI.Database.Administratori", "Administrator")
                        .WithMany("Lociranja")
                        .HasForeignKey("AdministratorId")
                        .HasConstraintName("FK_Lociranja_Administratori");

                    b.HasOne("Transport.WebAPI.Database.Klijenti", "Klijent")
                        .WithMany("Lociranja")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("FK_Lociranja_Klijenti");

                    b.HasOne("Transport.WebAPI.Database.Voznje", "Voznja")
                        .WithMany("Lociranja")
                        .HasForeignKey("VoznjaId")
                        .HasConstraintName("FK_Lociraja_Voznje")
                        .IsRequired();
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Obavijesti", b =>
                {
                    b.HasOne("Transport.WebAPI.Database.Voznje", "Voznja")
                        .WithMany("Obavijesti")
                        .HasForeignKey("VoznjaId")
                        .HasConstraintName("FK_Obavijesti_Voznje")
                        .IsRequired();
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Vozaci", b =>
                {
                    b.HasOne("Transport.WebAPI.Database.Gradovi", "Grad")
                        .WithMany("Vozaci")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK_Vozaci_Gradovi")
                        .IsRequired();

                    b.HasOne("Transport.WebAPI.Database.Vozila", "Vozilo")
                        .WithMany("Vozaci")
                        .HasForeignKey("VoziloId")
                        .HasConstraintName("FK_Vozaci_Vozila")
                        .IsRequired();
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Vozila", b =>
                {
                    b.HasOne("Transport.WebAPI.Database.TipoviVozila", "TipVozila")
                        .WithMany("Vozila")
                        .HasForeignKey("TipVozilaId")
                        .HasConstraintName("FK_Vozila_TipoviVozila")
                        .IsRequired();
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Voznje", b =>
                {
                    b.HasOne("Transport.WebAPI.Database.Vozaci", "Vozac")
                        .WithMany("Voznje")
                        .HasForeignKey("VozacId")
                        .HasConstraintName("FK_Odgovori_Vozaci")
                        .IsRequired();

                    b.HasOne("Transport.WebAPI.Database.Zahtjevi", "Zahtjev")
                        .WithMany("Voznje")
                        .HasForeignKey("ZahtjevId")
                        .HasConstraintName("FK_Voznje_Zahtjevi")
                        .IsRequired();
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Zahtjevi", b =>
                {
                    b.HasOne("Transport.WebAPI.Database.Klijenti", "Klijent")
                        .WithMany("Zahtjevi")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("FK_Zahtjevi_Klijenti")
                        .IsRequired();

                    b.HasOne("Transport.WebAPI.Database.TipoviRoba", "TipRobe")
                        .WithMany("Zahtjevi")
                        .HasForeignKey("TipRobeId")
                        .HasConstraintName("FK_Zahtijevi_TipoviRoba")
                        .IsRequired();

                    b.HasOne("Transport.WebAPI.Database.TipoviVozila", "TipVozila")
                        .WithMany("Zahtjevi")
                        .HasForeignKey("TipVozilaId")
                        .HasConstraintName("FK_Zahtjevi_TipoviVozila")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
