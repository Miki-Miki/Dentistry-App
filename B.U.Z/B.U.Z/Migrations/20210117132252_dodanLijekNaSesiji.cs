using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class dodanLijekNaSesiji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LijekNaSesiji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SesijaId = table.Column<int>(nullable: false),
                    LijekId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LijekNaSesiji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LijekNaSesiji_Lijekovi_LijekId",
                        column: x => x.LijekId,
                        principalTable: "Lijekovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LijekNaSesiji_Sesija_SesijaId",
                        column: x => x.SesijaId,
                        principalTable: "Sesija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LijekNaSesiji_LijekId",
                table: "LijekNaSesiji",
                column: "LijekId");

            migrationBuilder.CreateIndex(
                name: "IX_LijekNaSesiji_SesijaId",
                table: "LijekNaSesiji",
                column: "SesijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LijekNaSesiji");
        }
    }
}
