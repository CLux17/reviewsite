﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using reviewsite;

namespace reviewsite.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20190623165929_ProductSeedData")]
    partial class ProductSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("reviewsite.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Name = "Shoes" },
                        new { Id = 2, Name = "Drinks" }
                    );
                });

            modelBuilder.Entity("reviewsite.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("Review");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Description = "AirMax Based off the original Air Max 90, designer Virgil Abloh, decrostructed the design of the upper portion of the shoe. Seude & synthtic material's make the upper portion. While the OFF-WHITE branding can be seen on the medial sides of the shoe. Last but not least, is the famous tag located on the upper eyelet. This shoe is presented in the colorway of, Desert Ore/Hyper Jade/Bright Mango.", Image = "image.jpg", Name = "Nike Air Max 90's OFF-WHITE edition", Review = "The shoe is the last one of Virgil's Off-White collab for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark." },
                        new { Id = 2, CategoryId = 1, Description = "Aveline in black. Exquisite, extravagant and the epitome of elegance, this special occasion style hosts oversized bold crinoline bows to offer a 'same but different' look on each pump. The bows are intricately woven, hand tied and sewn on for a dramatic finish ", Image = "Jimmy-white.jpeg", Name = "High Heels Jimmy Choo", Review = "The shoe is as beautiful as it looks on the site. It's does run small so, I would recommend a 1/2 size up. As long as you're used to wearing heels they are good for an all night wear. Perfect for a dramatic night on the town or an elegant night out. Would I recommend this shoe? Absolutely!" },
                        new { Id = 3, CategoryId = 2, Description = "Coffee was first brought to the country of Brazil, by a man named Francisco de Melo Palheta, in 1727. He planted the first coffee tree in the state of Para and it thrived and made a easy transition to Rio de Janeiro by 1770. There are two types of beans that are used for production in Brazil. The first bean is called the robusta bean, the second is called the arabica bean. The majority of the coffee grown in Brazil is located in the southern portion of the country. Arabica is known to be the better tasting bean of the two types, and is also the majority in annual production at 80%. Brazil as a country has a annual production rate of 7.9 billion pounds, as of 2018 records. America is the leading country of coffee consumption at 400 million cup's per day. At this rate, coffee is not going anywhere but up, in the United States anytime soon.", Image = "coffee.jpg", Name = "Cold Brew Coffee", Review = "Coffee? yes. Iced or Cold brew coffee? Even better. This stuff right here? The best there is, hands down, nothing else wakes me up faster than this." },
                        new { Id = 4, CategoryId = 2, Description = "It's known as one of the best tasting energy drinks on the market, with a unique flavor unlike any of its competitors. Contains 260 mg of caffeine per can, higher than the caffeine content in a Red Bull, Rockstar, or Monster. Also offered in a variety of a few flavors including citrus, grape, and loaded cherry", Image = "XtremeShock.png", Name = "Shock Energy Drink", Review = "Feel it withing 15 minutes of drinkning it, fantastic for body building and tastes GREAT!!!!" }
                    );
                });

            modelBuilder.Entity("reviewsite.Model.Product", b =>
                {
                    b.HasOne("reviewsite.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
