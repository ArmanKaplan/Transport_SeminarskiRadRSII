using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Transport.WebAPI.Migrations
{
    public partial class migi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administratori",
                columns: table => new
                {
                    AdministratorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    Lozinka = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administratori", x => x.AdministratorID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                });

            migrationBuilder.CreateTable(
                name: "TipoviRoba",
                columns: table => new
                {
                    TipRobeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviRoba", x => x.TipRobeID);
                });

            migrationBuilder.CreateTable(
                name: "TipoviVozila",
                columns: table => new
                {
                    TipVozilaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviVozila", x => x.TipVozilaID);
                });

            migrationBuilder.CreateTable(
                name: "Klijenti",
                columns: table => new
                {
                    KlijentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Firma = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(maxLength: 20, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    Lozinka = table.Column<string>(maxLength: 50, nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijenti", x => x.KlijentID);
                    table.ForeignKey(
                        name: "FK_Klijenti_Gradovi",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vozila",
                columns: table => new
                {
                    VoziloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(maxLength: 50, nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    RegistracijskeOznake = table.Column<string>(maxLength: 10, nullable: false),
                    Kilovati = table.Column<int>(nullable: false),
                    Boja = table.Column<string>(maxLength: 20, nullable: false),
                    GodinaProizvodnje = table.Column<int>(nullable: false),
                    TipVozilaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozila", x => x.VoziloID);
                    table.ForeignKey(
                        name: "FK_Vozila_TipoviVozila",
                        column: x => x.TipVozilaID,
                        principalTable: "TipoviVozila",
                        principalColumn: "TipVozilaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjevi",
                columns: table => new
                {
                    ZahtjevID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaRobe = table.Column<string>(maxLength: 50, nullable: false),
                    TipVozilaID = table.Column<int>(nullable: false),
                    LokacijaUtovara = table.Column<string>(maxLength: 100, nullable: false),
                    LokacijaIstovara = table.Column<string>(maxLength: 100, nullable: false),
                    DatumTransporta = table.Column<DateTime>(type: "date", nullable: false),
                    Napomena = table.Column<string>(maxLength: 250, nullable: true),
                    Obradjen = table.Column<bool>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false),
                    TipRobeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjevi", x => x.ZahtjevID);
                    table.ForeignKey(
                        name: "FK_Zahtjevi_Klijenti",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zahtijevi_TipoviRoba",
                        column: x => x.TipRobeID,
                        principalTable: "TipoviRoba",
                        principalColumn: "TipRobeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zahtjevi_TipoviVozila",
                        column: x => x.TipVozilaID,
                        principalTable: "TipoviVozila",
                        principalColumn: "TipVozilaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vozaci",
                columns: table => new
                {
                    VozacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    JMBG = table.Column<string>(maxLength: 13, nullable: false),
                    MjestoRodjenja = table.Column<string>(maxLength: 50, nullable: true),
                    Adresa = table.Column<string>(maxLength: 50, nullable: true),
                    GodineIskustva = table.Column<int>(nullable: true),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    Lozinka = table.Column<string>(maxLength: 50, nullable: false),
                    VoziloID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozaci", x => x.VozacID);
                    table.ForeignKey(
                        name: "FK_Vozaci_Gradovi",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vozaci_Vozila",
                        column: x => x.VozacID,
                        principalTable: "Vozila",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Voznje",
                columns: table => new
                {
                    VoznjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prihvacen = table.Column<bool>(nullable: false),
                    Kilometraza = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    VozacID = table.Column<int>(nullable: false),
                    Napomena = table.Column<string>(maxLength: 250, nullable: true),
                    Zapoceto = table.Column<bool>(nullable: false),
                    Zavrsen = table.Column<bool>(nullable: false),
                    Ocjena = table.Column<int>(nullable: true),
                    Ocijenjen = table.Column<bool>(nullable: false),
                    ZahtjevID = table.Column<int>(nullable: false),
                    Odgovoren = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odgovori", x => x.VoznjaID);
                    table.ForeignKey(
                        name: "FK_Odgovori_Vozaci",
                        column: x => x.VozacID,
                        principalTable: "Vozaci",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voznje_Zahtjevi",
                        column: x => x.ZahtjevID,
                        principalTable: "Zahtjevi",
                        principalColumn: "ZahtjevID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kvarovi",
                columns: table => new
                {
                    KvarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lokacija = table.Column<string>(maxLength: 100, nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Prioritetno = table.Column<bool>(nullable: false),
                    VoznjaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kvarovi", x => x.KvarID);
                    table.ForeignKey(
                        name: "FK_Kvarovi_Voznje",
                        column: x => x.VoznjaID,
                        principalTable: "Voznje",
                        principalColumn: "VoznjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lociranja",
                columns: table => new
                {
                    LociranjeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoznjaID = table.Column<int>(nullable: false),
                    Lat = table.Column<string>(maxLength: 30, nullable: false),
                    Lng = table.Column<string>(maxLength: 30, nullable: false),
                    Prihvaceno = table.Column<bool>(nullable: false),
                    Odogovoreno = table.Column<bool>(nullable: false),
                    KlijentID = table.Column<int>(nullable: true),
                    AdministratorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lociranja", x => x.LociranjeID);
                    table.ForeignKey(
                        name: "FK_Lociranja_Administratori",
                        column: x => x.AdministratorID,
                        principalTable: "Administratori",
                        principalColumn: "AdministratorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lociranja_Klijenti",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lociraja_Voznje",
                        column: x => x.VoznjaID,
                        principalTable: "Voznje",
                        principalColumn: "VoznjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obavijesti",
                columns: table => new
                {
                    ObavijestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(maxLength: 250, nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    VoznjaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijesti", x => x.ObavijestID);
                    table.ForeignKey(
                        name: "FK_Obavijesti_Voznje",
                        column: x => x.VoznjaID,
                        principalTable: "Voznje",
                        principalColumn: "VoznjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_GradID",
                table: "Klijenti",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Kvarovi_VoznjaID",
                table: "Kvarovi",
                column: "VoznjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Lociranja_AdministratorID",
                table: "Lociranja",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_Lociranja_KlijentID",
                table: "Lociranja",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Lociranja_VoznjaID",
                table: "Lociranja",
                column: "VoznjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijesti_VoznjaID",
                table: "Obavijesti",
                column: "VoznjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozaci_GradID",
                table: "Vozaci",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_TipVozilaID",
                table: "Vozila",
                column: "TipVozilaID");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_VozacID",
                table: "Voznje",
                column: "VozacID");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_ZahtjevID",
                table: "Voznje",
                column: "ZahtjevID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevi_KlijentID",
                table: "Zahtjevi",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevi_TipRobeID",
                table: "Zahtjevi",
                column: "TipRobeID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevi_TipVozilaID",
                table: "Zahtjevi",
                column: "TipVozilaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kvarovi");

            migrationBuilder.DropTable(
                name: "Lociranja");

            migrationBuilder.DropTable(
                name: "Obavijesti");

            migrationBuilder.DropTable(
                name: "Administratori");

            migrationBuilder.DropTable(
                name: "Voznje");

            migrationBuilder.DropTable(
                name: "Vozaci");

            migrationBuilder.DropTable(
                name: "Zahtjevi");

            migrationBuilder.DropTable(
                name: "Vozila");

            migrationBuilder.DropTable(
                name: "Klijenti");

            migrationBuilder.DropTable(
                name: "TipoviRoba");

            migrationBuilder.DropTable(
                name: "TipoviVozila");

            migrationBuilder.DropTable(
                name: "Gradovi");
        }
    }
}
