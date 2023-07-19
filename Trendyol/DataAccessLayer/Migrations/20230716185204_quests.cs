using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class quests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Prd",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ProductId",
                table: "Questions",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Products_ProductId",
                table: "Questions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Products_ProductId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ProductId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Prd",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Questions");
        }
    }
}
