using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyManagementWebAPI.Migrations
{
    public partial class MigrationSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedExpDate",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "MedPrice",
                table: "Suppliers");

            migrationBuilder.AddColumn<double>(
                name: "SupplierPhnNum",
                table: "Suppliers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierPhnNum",
                table: "Suppliers");

            migrationBuilder.AddColumn<DateTime>(
                name: "MedExpDate",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MedPrice",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
