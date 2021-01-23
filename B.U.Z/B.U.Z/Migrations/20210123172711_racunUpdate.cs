using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class racunUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Napomena",
                table: "Racun");

            migrationBuilder.AlterColumn<double>(
                name: "stopaPDV",
                table: "Racun",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "UkupnaCijena",
                table: "Racun",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OsnovnaCijena",
                table: "Racun",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Datum",
                table: "Racun",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "SesijaId",
                table: "Racun",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Racun_SesijaId",
                table: "Racun",
                column: "SesijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Racun_Sesija_SesijaId",
                table: "Racun",
                column: "SesijaId",
                principalTable: "Sesija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Racun_Sesija_SesijaId",
                table: "Racun");

            migrationBuilder.DropIndex(
                name: "IX_Racun_SesijaId",
                table: "Racun");

            migrationBuilder.DropColumn(
                name: "SesijaId",
                table: "Racun");

            migrationBuilder.AlterColumn<double>(
                name: "stopaPDV",
                table: "Racun",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "UkupnaCijena",
                table: "Racun",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "OsnovnaCijena",
                table: "Racun",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Datum",
                table: "Racun",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Napomena",
                table: "Racun",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
