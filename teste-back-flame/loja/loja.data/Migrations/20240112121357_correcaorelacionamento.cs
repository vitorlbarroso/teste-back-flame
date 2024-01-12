using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loja.data.Migrations
{
    public partial class correcaorelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SalesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SalesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SalesId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Timestamps",
                table: "Products",
                newName: "timestamps");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsBlocked",
                table: "Products",
                newName: "isBlocked");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "timestamps",
                table: "Products",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProdutoId",
                table: "Sales",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Products_ProdutoId",
                table: "Sales",
                column: "ProdutoId",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_ProdutoId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ProdutoId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "timestamps",
                table: "Products",
                newName: "Timestamps");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isBlocked",
                table: "Products",
                newName: "IsBlocked");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Products",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Timestamps",
                table: "Products",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<int>(
                name: "SalesId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SalesId",
                table: "Products",
                column: "SalesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_SalesId",
                table: "Products",
                column: "SalesId",
                principalTable: "Sales",
                principalColumn: "Id");
        }
    }
}
