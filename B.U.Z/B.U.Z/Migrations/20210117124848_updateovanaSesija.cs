using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class updateovanaSesija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_Dijagnoze_DijagnozaId",
                table: "Sesija");

            migrationBuilder.DropIndex(
                name: "IX_Sesija_DijagnozaId",
                table: "Sesija");

            migrationBuilder.DropColumn(
                name: "DijagnozaId",
                table: "Sesija");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DijagnozaId",
                table: "Sesija",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sesija_DijagnozaId",
                table: "Sesija",
                column: "DijagnozaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_Dijagnoze_DijagnozaId",
                table: "Sesija",
                column: "DijagnozaId",
                principalTable: "Dijagnoze",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
