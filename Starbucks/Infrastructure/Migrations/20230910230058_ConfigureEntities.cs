using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class ConfigureEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrder_Items_OrderItemsId",
                table: "ItemOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrder_Orders_ItemOrdersId",
                table: "ItemOrder");

            migrationBuilder.RenameColumn(
                name: "CustomerPhoneNumber",
                table: "Orders",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Orders",
                newName: "Taxes");

            migrationBuilder.RenameColumn(
                name: "CustomerEmail",
                table: "Orders",
                newName: "SubTotal");

            migrationBuilder.RenameColumn(
                name: "CustomerAddress",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "OrderItemsId",
                table: "ItemOrder",
                newName: "OrdersId");

            migrationBuilder.RenameColumn(
                name: "ItemOrdersId",
                table: "ItemOrder",
                newName: "ItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemOrder_OrderItemsId",
                table: "ItemOrder",
                newName: "IX_ItemOrder_OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrder_Items_ItemsId",
                table: "ItemOrder",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrder_Orders_OrdersId",
                table: "ItemOrder",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrder_Items_ItemsId",
                table: "ItemOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrder_Orders_OrdersId",
                table: "ItemOrder");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Orders",
                newName: "CustomerPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Taxes",
                table: "Orders",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "SubTotal",
                table: "Orders",
                newName: "CustomerEmail");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "CustomerAddress");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "ItemOrder",
                newName: "OrderItemsId");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "ItemOrder",
                newName: "ItemOrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemOrder_OrdersId",
                table: "ItemOrder",
                newName: "IX_ItemOrder_OrderItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrder_Items_OrderItemsId",
                table: "ItemOrder",
                column: "OrderItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrder_Orders_ItemOrdersId",
                table: "ItemOrder",
                column: "ItemOrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
