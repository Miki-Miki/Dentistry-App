using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class updateSesija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Snimak",
                table: "CTNalaz");

            migrationBuilder.AddColumn<string>(
                name: "CTNalazSlika",
                table: "CTNalaz",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "CTNalaz",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CTNalazSlika",
                table: "CTNalaz");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "CTNalaz");

            migrationBuilder.AddColumn<byte[]>(
                name: "Snimak",
                table: "CTNalaz",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
