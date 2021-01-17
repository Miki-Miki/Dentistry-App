using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class DentalnaPomagala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DentalnaPomagala_AspNetUsers_PacijentId1",
                table: "DentalnaPomagala");

            migrationBuilder.DropIndex(
                name: "IX_DentalnaPomagala_PacijentId1",
                table: "DentalnaPomagala");

            migrationBuilder.DropColumn(
                name: "PacijentId1",
                table: "DentalnaPomagala");

            migrationBuilder.AlterColumn<string>(
                name: "PacijentId",
                table: "DentalnaPomagala",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DentalnaPomagala_PacijentId",
                table: "DentalnaPomagala",
                column: "PacijentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DentalnaPomagala_AspNetUsers_PacijentId",
                table: "DentalnaPomagala",
                column: "PacijentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DentalnaPomagala_AspNetUsers_PacijentId",
                table: "DentalnaPomagala");

            migrationBuilder.DropIndex(
                name: "IX_DentalnaPomagala_PacijentId",
                table: "DentalnaPomagala");

            migrationBuilder.AlterColumn<int>(
                name: "PacijentId",
                table: "DentalnaPomagala",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PacijentId1",
                table: "DentalnaPomagala",
                type: "nvarchar(450)",
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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
