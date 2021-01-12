using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Transport.WebAPI.Migrations
{
    public partial class migi : Migration
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
                    Lozinka = table.Column<string>(maxLength: 20, nullable: false)
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
                    GradID = table.Column<int>(nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 70, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 70, nullable: false)
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
                    TipRobeID = table.Column<int>(nullable: false),
                    Uplaceno = table.Column<bool>(nullable: false),
                    Odbijen = table.Column<bool>(nullable: false),
                    Transakcija = table.Column<string>(nullable: true)
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
                    GradID = table.Column<int>(nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 70, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 70, nullable: false),
                    VoziloID = table.Column<int>(nullable: false)
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
                        column: x => x.VoziloID,
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
                    VoznjaID = table.Column<int>(nullable: false),
                    Lat = table.Column<string>(nullable: true),
                    Lng = table.Column<string>(nullable: true)
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

            migrationBuilder.InsertData(
                table: "Administratori",
                columns: new[] { "AdministratorID", "KorisnickoIme", "Lozinka" },
                values: new object[] { 1, "Administrator", "admin" });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "Naziv" },
                values: new object[,]
                {
                    { 10, "Stolac" },
                    { 2, "Mostar" },
                    { 3, "Sarajevo" },
                    { 4, "Tuzla" },
                    { 5, "Zenica" },
                    { 6, "Kakanj" }
                });

            migrationBuilder.InsertData(
                table: "TipoviRoba",
                columns: new[] { "TipRobeID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Lomljiva" },
                    { 2, "Zapaljiva" },
                    { 3, "Prioritetna" },
                    { 4, "Ostalo" }
                });

            migrationBuilder.InsertData(
                table: "TipoviVozila",
                columns: new[] { "TipVozilaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Sa ceradom" },
                    { 2, "Bez cerade" },
                    { 3, "Šlepa" }
                });

            migrationBuilder.InsertData(
                table: "Klijenti",
                columns: new[] { "KlijentID", "Email", "Firma", "GradID", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Telefon" },
                values: new object[] { 1, "klijent@gmail.com", "MM-Comerce", 10, "Arman", "Klijent", "7bR9xZtoXzV010VzMhJ18P+HWt4=", "FNECPo7it/SExHjE7fzmew==", "Kaplan", "062-437-836" });

            migrationBuilder.InsertData(
                table: "Vozila",
                columns: new[] { "VoziloID", "Boja", "GodinaProizvodnje", "Kilovati", "Marka", "Model", "RegistracijskeOznake", "TipVozilaID" },
                values: new object[] { 1, "Crvena", 2019, 230, "Mercedes-Benz", "Actros", "TN0-K-2MN", 1 });

            migrationBuilder.InsertData(
                table: "Vozila",
                columns: new[] { "VoziloID", "Boja", "GodinaProizvodnje", "Kilovati", "Marka", "Model", "RegistracijskeOznake", "TipVozilaID" },
                values: new object[] { 2, "Zelena", 2018, 250, "Mercedes-Benz", "Actros", "SG0-N-1KN", 2 });

            migrationBuilder.InsertData(
                table: "Vozaci",
                columns: new[] { "VozacID", "Adresa", "GodineIskustva", "GradID", "Ime", "JMBG", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "MjestoRodjenja", "Prezime", "VoziloID" },
                values: new object[,]
                {
                    { 2, "Krajsina bb", 4, 10, "Sakib", "189423615559", "Vozac2", "vIQcy12pFXZuN1vs8OyefzVyd5A=", "m7sQeHGBYf+oZM0hBN3Eqw==", "Sarajevo", "Hodzić", 1 },
                    { 1, "Rivine bb", 2, 10, "Arman", "1899996153759", "Vozac", "vIQcy12pFXZuN1vs8OyefzVyd5A=", "m7sQeHGBYf+oZM0hBN3Eqw==", "Mostar", "Kaplan", 2 }
                });

            migrationBuilder.InsertData(
                table: "Zahtjevi",
                columns: new[] { "ZahtjevID", "DatumTransporta", "KlijentID", "LokacijaIstovara", "LokacijaUtovara", "Napomena", "Obradjen", "Odbijen", "TipRobeID", "TipVozilaID", "Transakcija", "Uplaceno", "VrstaRobe" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 12, 12, 49, 51, 989, DateTimeKind.Local).AddTicks(3149), 1, "Mostar, Maršala Tita 94", "Mostar, Bišće polje", "Molim vas da budete tačni", false, false, 1, 1, null, false, "Tkanina" },
                    { 2, new DateTime(2021, 1, 12, 12, 49, 51, 995, DateTimeKind.Local).AddTicks(720), 1, "Sarajevo, Ul. Šenoina br. 1", "Mostar, Bišće polje", "Molim vas da budete tačni", false, false, 1, 1, null, false, "Porculan" },
                    { 3, new DateTime(2021, 1, 12, 12, 49, 51, 995, DateTimeKind.Local).AddTicks(1060), 1, "Sarajevo, Ul. Šenoina br. 1", "Stolac, Humska bb", "Molim vas da budete tačni", false, false, 2, 2, null, false, "Drva" },
                    { 4, new DateTime(2021, 1, 12, 12, 49, 51, 995, DateTimeKind.Local).AddTicks(1137), 1, "Sarajevo, Ul. Šenoina br. 1", "Stolac, Humska bb", "Molim vas da budete tačni", true, false, 2, 2, null, false, "Drva" },
                    { 5, new DateTime(2021, 1, 12, 12, 49, 51, 995, DateTimeKind.Local).AddTicks(1206), 1, "Stolac, Humska bb", "Sarajevo, Ul. Šenoina br. 1", "Molim vas da budete tačni", true, false, 2, 2, null, false, "Drva" },
                    { 8, new DateTime(2021, 1, 12, 12, 49, 51, 995, DateTimeKind.Local).AddTicks(1281), 1, "Stolac, Humska bb", "Ljubinje, Bančići", "Molim vas da budete tačni", true, false, 2, 2, null, false, "Drva" },
                    { 6, new DateTime(2021, 1, 12, 12, 49, 51, 995, DateTimeKind.Local).AddTicks(1347), 1, "Bihac, Nade Kalić", "Tuzla, Titova", "Molim vas da budete tačni", true, true, 2, 2, null, false, "Drva" },
                    { 7, new DateTime(2021, 1, 12, 12, 49, 51, 995, DateTimeKind.Local).AddTicks(1413), 1, "Trebinje, Pridovci", "Zvornik, Divič", "Molim vas da budete tačni", true, true, 2, 2, null, false, "Drva" },
                    { 9, new DateTime(2021, 1, 12, 12, 49, 51, 995, DateTimeKind.Local).AddTicks(1477), 1, "Trebinje, Pridovci", "Kladanj, Buševo", "Molim vas da budete tačni", true, false, 2, 2, null, false, "Pelet" }
                });

            migrationBuilder.InsertData(
                table: "Voznje",
                columns: new[] { "VoznjaID", "Cijena", "Kilometraza", "Napomena", "Ocijenjen", "Ocjena", "Odgovoren", "Prihvacen", "VozacID", "ZahtjevID", "Zapoceto", "Zavrsen" },
                values: new object[,]
                {
                    { 4, 554m, 231, "Naravno", false, null, true, true, 2, 9, true, false },
                    { 1, 554m, 231, "Naravno", false, null, true, true, 1, 1, true, false },
                    { 2, 554m, 231, "Naravno", false, null, true, true, 1, 5, true, true },
                    { 3, 159m, 45, "Naravno", true, null, true, true, 1, 8, true, true }
                });

            migrationBuilder.InsertData(
                table: "Kvarovi",
                columns: new[] { "KvarID", "Lat", "Lng", "Lokacija", "Opis", "Prioritetno", "VoznjaID" },
                values: new object[] { 1, "43.33373", "17.81410", "Mostar, Bulevar", "Vozilo se ugasilo u voznji, ne moze se ponovno pokrenuti.", true, 1 });

            migrationBuilder.InsertData(
                table: "Lociranja",
                columns: new[] { "LociranjeID", "AdministratorID", "KlijentID", "Lat", "Lng", "Odogovoreno", "Prihvaceno", "VoznjaID" },
                values: new object[,]
                {
                    { 1, 1, null, "43.33373", "17.81410", true, true, 1 },
                    { 2, null, 1, "43.33373", "17.81410", true, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "Obavijesti",
                columns: new[] { "ObavijestID", "Datum", "Tekst", "VoznjaID" },
                values: new object[] { 1, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Molim te drzi se dogovora.", 1 });

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
                name: "IX_Vozaci_VoziloID",
                table: "Vozaci",
                column: "VoziloID");

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
