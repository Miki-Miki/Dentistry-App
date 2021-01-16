using Microsoft.EntityFrameworkCore.Migrations;

namespace B.U.Z.Migrations
{
    public partial class dodaneNullVrijednostiZaSesiju : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_CTNalaz_CTNalazId",
                table: "Sesija");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_DentalnaPomagala_DentalnoPomagaloId",
                table: "Sesija");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_Lijekovi_LijekId",
                table: "Sesija");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_Termini_TerminId",
                table: "Sesija");

            migrationBuilder.AlterColumn<int>(
                name: "TerminId",
                table: "Sesija",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LijekId",
                table: "Sesija",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DentalnoPomagaloId",
                table: "Sesija",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CTNalazId",
                table: "Sesija",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_CTNalaz_CTNalazId",
                table: "Sesija",
                column: "CTNalazId",
                principalTable: "CTNalaz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_Termini_TerminId",
                table: "Sesija",
                column: "TerminId",
                principalTable: "Termini",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_CTNalaz_CTNalazId",
                table: "Sesija");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_DentalnaPomagala_DentalnoPomagaloId",
                table: "Sesija");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_Lijekovi_LijekId",
                table: "Sesija");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesija_Termini_TerminId",
                table: "Sesija");

            migrationBuilder.AlterColumn<int>(
                name: "TerminId",
                table: "Sesija",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LijekId",
                table: "Sesija",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DentalnoPomagaloId",
                table: "Sesija",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CTNalazId",
                table: "Sesija",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_CTNalaz_CTNalazId",
                table: "Sesija",
                column: "CTNalazId",
                principalTable: "CTNalaz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_DentalnaPomagala_DentalnoPomagaloId",
                table: "Sesija",
                column: "DentalnoPomagaloId",
                principalTable: "DentalnaPomagala",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_Lijekovi_LijekId",
                table: "Sesija",
                column: "LijekId",
                principalTable: "Lijekovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sesija_Termini_TerminId",
                table: "Sesija",
                column: "TerminId",
                principalTable: "Termini",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
