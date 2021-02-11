using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class obavijesti_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Obavijesti",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isProcitana",
                table: "Obavijesti",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Obavijesti");

            migrationBuilder.DropColumn(
                name: "isProcitana",
                table: "Obavijesti");
        }
    }
}
