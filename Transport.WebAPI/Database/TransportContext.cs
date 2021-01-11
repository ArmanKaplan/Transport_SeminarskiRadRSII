using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Transport.WebAPI.Database
{
    public partial class TransportContext : DbContext
    {
        public TransportContext()
        {
        }

        public TransportContext(DbContextOptions<TransportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administratori> Administratori { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Klijenti> Klijenti { get; set; }
        public virtual DbSet<Kvarovi> Kvarovi { get; set; }
        public virtual DbSet<Lociranja> Lociranja { get; set; }
        public virtual DbSet<Obavijesti> Obavijesti { get; set; }
        public virtual DbSet<TipoviRoba> TipoviRoba { get; set; }
        public virtual DbSet<TipoviVozila> TipoviVozila { get; set; }
        public virtual DbSet<Vozaci> Vozaci { get; set; }
        public virtual DbSet<Vozila> Vozila { get; set; }
        public virtual DbSet<Voznje> Voznje { get; set; }
        public virtual DbSet<Zahtjevi> Zahtjevi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Transport;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administratori>(entity =>
            {
                entity.HasKey(e => e.AdministratorId);

                entity.Property(e => e.AdministratorId).HasColumnName("AdministratorID");

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lozinka)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Klijenti>(entity =>
            {
                entity.HasKey(e => e.KlijentId);

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Firma)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Klijenti)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Klijenti_Gradovi");
            });

            modelBuilder.Entity<Kvarovi>(entity =>
            {
                entity.HasKey(e => e.KvarId);

                entity.Property(e => e.KvarId).HasColumnName("KvarID");

                entity.Property(e => e.Lokacija).HasMaxLength(100);

                entity.Property(e => e.VoznjaId).HasColumnName("VoznjaID");

                entity.HasOne(d => d.Voznja)
                    .WithMany(p => p.Kvarovi)
                    .HasForeignKey(d => d.VoznjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kvarovi_Voznje");
            });

            modelBuilder.Entity<Lociranja>(entity =>
            {
                entity.HasKey(e => e.LociranjeId);

                entity.Property(e => e.LociranjeId).HasColumnName("LociranjeID");

                entity.Property(e => e.AdministratorId).HasColumnName("AdministratorID");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Lng)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.VoznjaId).HasColumnName("VoznjaID");

                entity.HasOne(d => d.Administrator)
                    .WithMany(p => p.Lociranja)
                    .HasForeignKey(d => d.AdministratorId)
                    .HasConstraintName("FK_Lociranja_Administratori");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Lociranja)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK_Lociranja_Klijenti");

                entity.HasOne(d => d.Voznja)
                    .WithMany(p => p.Lociranja)
                    .HasForeignKey(d => d.VoznjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lociraja_Voznje");
            });

            modelBuilder.Entity<Obavijesti>(entity =>
            {
                entity.HasKey(e => e.ObavijestId);

                entity.Property(e => e.ObavijestId).HasColumnName("ObavijestID");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Tekst)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.VoznjaId).HasColumnName("VoznjaID");

                entity.HasOne(d => d.Voznja)
                    .WithMany(p => p.Obavijesti)
                    .HasForeignKey(d => d.VoznjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obavijesti_Voznje");
            });

            modelBuilder.Entity<TipoviRoba>(entity =>
            {
                entity.HasKey(e => e.TipRobeId);

                entity.Property(e => e.TipRobeId).HasColumnName("TipRobeID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TipoviVozila>(entity =>
            {
                entity.HasKey(e => e.TipVozilaId);

                entity.Property(e => e.TipVozilaId).HasColumnName("TipVozilaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vozaci>(entity =>
            {
                entity.HasKey(e => e.VozacId);

                entity.Property(e => e.VozacId).HasColumnName("VozacID");

                entity.Property(e => e.Adresa).HasMaxLength(50);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Jmbg)
                    .IsRequired()
                    .HasColumnName("JMBG")
                    .HasMaxLength(13);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.MjestoRodjenja).HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Vozaci)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozaci_Gradovi");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.Vozaci)
                    .HasForeignKey(d => d.VoziloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozaci_Vozila");
            });

            modelBuilder.Entity<Vozila>(entity =>
            {
                entity.HasKey(e => e.VoziloId);

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.Property(e => e.Boja)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Marka)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegistracijskeOznake)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TipVozilaId).HasColumnName("TipVozilaID");

                entity.HasOne(d => d.TipVozila)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.TipVozilaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_TipoviVozila");
            });

            modelBuilder.Entity<Voznje>(entity =>
            {
                entity.HasKey(e => e.VoznjaId)
                    .HasName("PK_Odgovori");

                entity.Property(e => e.VoznjaId).HasColumnName("VoznjaID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Napomena).HasMaxLength(250);

                entity.Property(e => e.VozacId).HasColumnName("VozacID");

                entity.Property(e => e.ZahtjevId).HasColumnName("ZahtjevID");

                entity.HasOne(d => d.Vozac)
                    .WithMany(p => p.Voznje)
                    .HasForeignKey(d => d.VozacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Odgovori_Vozaci");

                entity.HasOne(d => d.Zahtjev)
                    .WithMany(p => p.Voznje)
                    .HasForeignKey(d => d.ZahtjevId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Voznje_Zahtjevi");
            });

            modelBuilder.Entity<Zahtjevi>(entity =>
            {
                entity.HasKey(e => e.ZahtjevId);

                entity.Property(e => e.ZahtjevId).HasColumnName("ZahtjevID");

                entity.Property(e => e.DatumTransporta).HasColumnType("date");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.LokacijaIstovara)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LokacijaUtovara)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Napomena).HasMaxLength(250);

                entity.Property(e => e.TipRobeId).HasColumnName("TipRobeID");

                entity.Property(e => e.TipVozilaId).HasColumnName("TipVozilaID");

                entity.Property(e => e.VrstaRobe)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Zahtjevi)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zahtjevi_Klijenti");

                entity.HasOne(d => d.TipRobe)
                    .WithMany(p => p.Zahtjevi)
                    .HasForeignKey(d => d.TipRobeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zahtijevi_TipoviRoba");

                entity.HasOne(d => d.TipVozila)
                    .WithMany(p => p.Zahtjevi)
                    .HasForeignKey(d => d.TipVozilaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zahtjevi_TipoviVozila");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
