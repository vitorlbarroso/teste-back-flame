using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loja.data.Migrations
{
    public partial class enums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Sales");
        }
    }
}
