using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace reviewsite.Migrations
{
    public partial class NewModelAddRemoveData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Content", "ProductId" },
                values: new object[,]
                {
                    { 1, "The shoe is the last one of Virgil's Off-White collab for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark.", 1 },
                    { 2, "The shoe is as beautiful as it looks on the site. It's does run small so, I would recommend a 1/2 size up. As long as you're used to wearing heels they are good for an all night wear. Perfect for a dramatic night on the town or an elegant night out. Would I recommend this shoe? Absolutely!", 2 },
                    { 3, "Coffee? yes. Iced or Cold brew coffee? Even better. This stuff right here? The best there is, hands down, nothing else wakes me up faster than this.", 3 },
                    { 4, "Feel it withing 15 minutes of drinkning it, fantastic for body building and tastes GREAT!!!!", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductId",
                table: "Review",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Products",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Review",
                value: "The shoe is the last one of Virgil's Off-White collab for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Review",
                value: "The shoe is as beautiful as it looks on the site. It's does run small so, I would recommend a 1/2 size up. As long as you're used to wearing heels they are good for an all night wear. Perfect for a dramatic night on the town or an elegant night out. Would I recommend this shoe? Absolutely!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Review",
                value: "Coffee? yes. Iced or Cold brew coffee? Even better. This stuff right here? The best there is, hands down, nothing else wakes me up faster than this.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Review",
                value: "Feel it withing 15 minutes of drinkning it, fantastic for body building and tastes GREAT!!!!");
        }
    }
}
