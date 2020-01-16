using Microsoft.EntityFrameworkCore.Migrations;

namespace TillApp.Server.Migrations
{
    public partial class addedIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Products_productId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Items",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Items",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Items_productId",
                table: "Items",
                newName: "IX_Items_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OrderId",
                table: "Items",
                newName: "IX_Items_OrderID");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrderID",
                table: "Items",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Products_ProductID",
                table: "Items",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_OrderID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Products_ProductID",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Items",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Items",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ProductID",
                table: "Items",
                newName: "IX_Items_productId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OrderID",
                table: "Items",
                newName: "IX_Items_OrderId");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Products_productId",
                table: "Items",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
