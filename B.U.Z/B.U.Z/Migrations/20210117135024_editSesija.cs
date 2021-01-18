using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class editSesija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_DentalnaPomagala_DentalnoPomagaloId",
                table: "Sesija");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_Lijekovi_LijekId",
                table: "Sesija");

            migrationBuilder.DropIndex(
                name: "IX_Sesija_DentalnoPomagaloId",
                table: "Sesija");

            migrationBuilder.DropIndex(
                name: "IX_Sesija_LijekId",
                table: "Sesija");

            migrationBuilder.DropColumn(
                name: "DentalnoPomagaloId",
                table: "Sesija");

            migrationBuilder.DropColumn(
                name: "LijekId",
                table: "Sesija");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DentalnoPomagaloId",
                table: "Sesija",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LijekId",
                table: "Sesija",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sesija_DentalnoPomagaloId",
                table: "Sesija",
                column: "DentalnoPomagaloId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesija_LijekId",
                table: "Sesija",
                column: "LijekId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_DentalnaPomagala_DentalnoPomagaloId",
                table: "Sesija",
                column: "DentalnoPomagaloId",
                principalTable: "DentalnaPomagala",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_Lijekovi_LijekId",
                table: "Sesija",
                column: "LijekId",
                principalTable: "Lijekovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
