using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyManagementWebAPI.Migrations
{
    public partial class OrderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Orders_OrderId",
                table: "Medicines");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_OrderId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Medicines");

            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MedicineId",
                table: "Orders",
                column: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Medicines_MedicineId",
                table: "Orders",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "MedicineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Medicines_MedicineId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MedicineId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_OrderId",
                table: "Medicines",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Orders_OrderId",
                table: "Medicines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }
    }
}
