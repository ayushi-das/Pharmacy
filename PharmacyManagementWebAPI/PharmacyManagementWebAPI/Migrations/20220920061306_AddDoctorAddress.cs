using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyManagementWebAPI.Migrations
{
    public partial class AddDoctorAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DocPhnNum",
                table: "Doctors",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DocAddress",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocAddress",
                table: "Doctors");

            migrationBuilder.AlterColumn<string>(
                name: "DocPhnNum",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
