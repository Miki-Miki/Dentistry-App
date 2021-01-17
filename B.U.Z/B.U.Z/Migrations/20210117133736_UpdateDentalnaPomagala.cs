using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class UpdateDentalnaPomagala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vrsta",
                table: "DentalnaPomagala");

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "DentalnaPomagala",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacijentId",
                table: "DentalnaPomagala",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PacijentId1",
                table: "DentalnaPomagala",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DentalnaPomagala_PacijentId1",
                table: "DentalnaPomagala",
                column: "PacijentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DentalnaPomagala_AspNetUsers_PacijentId1",
                table: "DentalnaPomagala",
                column: "PacijentId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DentalnaPomagala_AspNetUsers_PacijentId1",
                table: "DentalnaPomagala");

            migrationBuilder.DropIndex(
                name: "IX_DentalnaPomagala_PacijentId1",
                table: "DentalnaPomagala");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "DentalnaPomagala");

            migrationBuilder.DropColumn(
                name: "PacijentId",
                table: "DentalnaPomagala");

            migrationBuilder.DropColumn(
                name: "PacijentId1",
                table: "DentalnaPomagala");

            migrationBuilder.AddColumn<string>(
                name: "Vrsta",
                table: "DentalnaPomagala",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
