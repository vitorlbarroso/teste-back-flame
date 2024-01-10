using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loja.data.Migrations
{
    public partial class createdbv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Vendas_SalesId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendas",
                table: "Vendas");

            migrationBuilder.RenameTable(
                name: "Vendas",
                newName: "Sales");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_SalesId",
                table: "Products",
                column: "SalesId",
                principalTable: "Sales",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SalesId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Vendas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendas",
                table: "Vendas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Vendas_SalesId",
                table: "Products",
                column: "SalesId",
                principalTable: "Vendas",
                principalColumn: "Id");
        }
    }
}
