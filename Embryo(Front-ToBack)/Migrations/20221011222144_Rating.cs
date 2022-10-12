using Microsoft.EntityFrameworkCore.Migrations;

namespace Embryo_Front_ToBack_.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "accessories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "accessories",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "accessories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "accessories");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "accessories");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "accessories");
        }
    }
}
