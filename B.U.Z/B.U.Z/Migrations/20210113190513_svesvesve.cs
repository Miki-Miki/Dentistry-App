using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class svesvesve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CTNalaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nalaz = table.Column<string>(nullable: true),
                    Snimak = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTNalaz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DentalnaPomagala",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Vrsta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DentalnaPomagala", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UkupnaCijena = table.Column<double>(nullable: false),
                    OsnovnaCijena = table.Column<double>(nullable: false),
                    stopaPDV = table.Column<double>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Napomena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terapije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usluga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usluga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sesija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LijekId = table.Column<int>(nullable: false),
                    CTNalazId = table.Column<int>(nullable: false),
                    TerminId = table.Column<int>(nullable: false),
                    StomatologId = table.Column<string>(nullable: true),
                    DentalnoPomagaloId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sesija_CTNalaz_CTNalazId",
                        column: x => x.CTNalazId,
                        principalTable: "CTNalaz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sesija_DentalnaPomagala_DentalnoPomagaloId",
                        column: x => x.DentalnoPomagaloId,
                        principalTable: "DentalnaPomagala",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sesija_Lijekovi_LijekId",
                        column: x => x.LijekId,
                        principalTable: "Lijekovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sesija_AspNetUsers_StomatologId",
                        column: x => x.StomatologId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sesija_Termini_TerminId",
                        column: x => x.TerminId,
                        principalTable: "Termini",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ZakazanaUsluga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(nullable: true),
                    UslugaId = table.Column<int>(nullable: false),
                    TerminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZakazanaUsluga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZakazanaUsluga_Termini_TerminId",
                        column: x => x.TerminId,
                        principalTable: "Termini",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ZakazanaUsluga_Usluga_UslugaId",
                        column: x => x.UslugaId,
                        principalTable: "Usluga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DentalnoPomagaloNaSesiji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SesijaId = table.Column<int>(nullable: false),
                    DentalnoPomgaloId = table.Column<int>(nullable: false),
                    DatumIzdavanja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DentalnoPomagaloNaSesiji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DentalnoPomagaloNaSesiji_DentalnaPomagala_DentalnoPomgaloId",
                        column: x => x.DentalnoPomgaloId,
                        principalTable: "DentalnaPomagala",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DentalnoPomagaloNaSesiji_Sesija_SesijaId",
                        column: x => x.SesijaId,
                        principalTable: "Sesija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DijagnozaNaSesiji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DijagnozaId = table.Column<int>(nullable: false),
                    SesijaId = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DijagnozaNaSesiji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DijagnozaNaSesiji_Dijagnoze_DijagnozaId",
                        column: x => x.DijagnozaId,
                        principalTable: "Dijagnoze",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DijagnozaNaSesiji_Sesija_SesijaId",
                        column: x => x.SesijaId,
                        principalTable: "Sesija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TerapijaNaSesiji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerapijaId = table.Column<int>(nullable: false),
                    SesijaId = table.Column<int>(nullable: false),
                    Instrukcije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerapijaNaSesiji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TerapijaNaSesiji_Sesija_SesijaId",
                        column: x => x.SesijaId,
                        principalTable: "Sesija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TerapijaNaSesiji_Terapije_TerapijaId",
                        column: x => x.TerapijaId,
                        principalTable: "Terapije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DentalnoPomagaloNaSesiji_DentalnoPomgaloId",
                table: "DentalnoPomagaloNaSesiji",
                column: "DentalnoPomgaloId");

            migrationBuilder.CreateIndex(
                name: "IX_DentalnoPomagaloNaSesiji_SesijaId",
                table: "DentalnoPomagaloNaSesiji",
                column: "SesijaId");

            migrationBuilder.CreateIndex(
                name: "IX_DijagnozaNaSesiji_DijagnozaId",
                table: "DijagnozaNaSesiji",
                column: "DijagnozaId");

            migrationBuilder.CreateIndex(
                name: "IX_DijagnozaNaSesiji_SesijaId",
                table: "DijagnozaNaSesiji",
                column: "SesijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesija_CTNalazId",
                table: "Sesija",
                column: "CTNalazId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesija_DentalnoPomagaloId",
                table: "Sesija",
                column: "DentalnoPomagaloId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesija_LijekId",
                table: "Sesija",
                column: "LijekId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesija_StomatologId",
                table: "Sesija",
                column: "StomatologId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesija_TerminId",
                table: "Sesija",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_TerapijaNaSesiji_SesijaId",
                table: "TerapijaNaSesiji",
                column: "SesijaId");

            migrationBuilder.CreateIndex(
                name: "IX_TerapijaNaSesiji_TerapijaId",
                table: "TerapijaNaSesiji",
                column: "TerapijaId");

            migrationBuilder.CreateIndex(
                name: "IX_ZakazanaUsluga_TerminId",
                table: "ZakazanaUsluga",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_ZakazanaUsluga_UslugaId",
                table: "ZakazanaUsluga",
                column: "UslugaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DentalnoPomagaloNaSesiji");

            migrationBuilder.DropTable(
                name: "DijagnozaNaSesiji");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "TerapijaNaSesiji");

            migrationBuilder.DropTable(
                name: "ZakazanaUsluga");

            migrationBuilder.DropTable(
                name: "Sesija");

            migrationBuilder.DropTable(
                name: "Terapije");

            migrationBuilder.DropTable(
                name: "Usluga");

            migrationBuilder.DropTable(
                name: "CTNalaz");

            migrationBuilder.DropTable(
                name: "DentalnaPomagala");
        }
    }
}
