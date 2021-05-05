using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace jwtAPIauth.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryImage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryCatID = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FileName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OriginalFileName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    isFeaturedImage = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryImage_Categories_CategoryCatID",
                        column: x => x.CategoryCatID,
                        principalTable: "Categories",
                        principalColumn: "CatID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryImage_CategoryCatID",
                table: "CategoryImage",
                column: "CategoryCatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryImage");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");
        }
    }
}
