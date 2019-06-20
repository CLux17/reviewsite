using Microsoft.EntityFrameworkCore.Migrations;

namespace reviewsite.Migrations
{
    public partial class FirstSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Reviews",
                nullable: true);

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
                values: new object[] { 1, 1, "AirMax Based off the original Air Max 90, designer Virgil Abloh, decrostructed the design of the upper portion of the shoe. Seude & synthtic material's make the upper portion. While the OFF-WHITE branding can be seen on the medial sides of the shoe. Last but not least, is the famous tag located on the upper eyelet. This shoe is presented in the colorway of, Desert Ore/Hyper Jade/Bright Mango.The shoe is the last one of Virgil's Off-White collab for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark.", "Nike Air Max 90's OFF-WHITE edition" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Reviews");
        }
    }
}
