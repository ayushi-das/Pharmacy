using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyManagementWebAPI.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MedName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MedPrice",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MedPrice",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "Orders");
        }
    }
}
