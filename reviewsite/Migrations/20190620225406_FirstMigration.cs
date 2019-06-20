using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace reviewsite.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Shoes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Drinks" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "Name" },
                values: new object[,]
                {
                    { 1, 1, "The shoe is the last one of Virgil's Off-White collab for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark.", "Nike Air Max 90's OFF-WHITE edition" },
                    { 2, 1, "The shoe is as beautiful as it looks on the site. It's does run small so, I would recommend a 1/2 size up. As long as you're used to wearing heels they are good for an all night wear. Perfect for a dramatic night on the town or an elegant night out. Would I recommend this shoe? Absolutely!", "High Heels Jimmy Choo" },
                    { 3, 2, "Coffee? yes. Iced or Cold brew coffee? Even better. This stuff right here? The best there is, hands down, nothing else wakes me up faster than this.", "Cold Brew Coffee" },
                    { 4, 2, "Feel it withing 15 minutes of drinkning it, fantastic for body building and tastes GREAT!!!!", "Shock Energy Drink" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CategoryId",
                table: "Reviews",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
