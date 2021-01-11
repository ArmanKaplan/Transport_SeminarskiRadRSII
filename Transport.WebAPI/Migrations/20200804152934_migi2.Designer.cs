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
    [Migration("20200804152934_migi2")]
    partial class migi2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
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
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("AdministratorId");

                    b.ToTable("Administratori");
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

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

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
                });

            modelBuilder.Entity("Transport.WebAPI.Database.Kvarovi", b =>
                {
                    b.Property<int>("KvarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KvarID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

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

                    b.ToTable("Vozaci");
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

                    b.Property<int>("TipRobeId")
                        .HasColumnName("TipRobeID")
                        .HasColumnType("int");

                    b.Property<int>("TipVozilaId")
                        .HasColumnName("TipVozilaID")
                        .HasColumnType("int");

                    b.Property<string>("VrstaRobe")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ZahtjevId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("TipRobeId");

                    b.HasIndex("TipVozilaId");

                    b.ToTable("Zahtjevi");
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

                    b.HasOne("Transport.WebAPI.Database.Vozila", "Vozac")
                        .WithOne("Vozaci")
                        .HasForeignKey("Transport.WebAPI.Database.Vozaci", "VozacId")
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