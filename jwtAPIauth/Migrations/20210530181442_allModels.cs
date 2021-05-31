using Microsoft.EntityFrameworkCore.Migrations;

namespace jwtAPIauth.Migrations
{
    public partial class allModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Products",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Prix",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Adresse",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Prix",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Adresse",
                table: "AspNetUsers");
        }
    }
}
