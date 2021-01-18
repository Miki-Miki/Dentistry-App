using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class sesijaVMupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "CTNalaz");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "CTNalaz",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
