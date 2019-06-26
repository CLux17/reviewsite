using Microsoft.EntityFrameworkCore.Migrations;

namespace reviewsite.Migrations
{
    public partial class reviewId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reviews",
                newName: "ReviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Reviews",
                newName: "Id");
        }
    }
}
