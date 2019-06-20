using reviewsite.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite
{
    public class SiteContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=aajcreviewsiteDb;Trusted_Connection=True;";

            //optionsBuilder.UseSqlServer(connectionString)
            //.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Shoes",
                    
                },
                new Category
                {
                    Id=2,
                    Name="Drinks",
                }
            );
            modelBuilder.Entity<Review>().HasData(
                new Review {
                    Id = 1,
                    Name = "Nike Air Max 90's OFF-WHITE edition",
                    Content = 
                    "The shoe is the last one of Virgil's Off-White collab for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark.",
                    CategoryId = 1
                },


                new Review
                    {
                    Id = 2,
                    Name = "High Heels Jimmy Choo",
                    Content = 
                    "The shoe is as beautiful as it looks on the site. It's does run small so, I would recommend a 1/2 size up. As long as you're used to wearing heels they are good for an all night wear. Perfect for a dramatic night on the town or an elegant night out. Would I recommend this shoe? Absolutely!",
                    CategoryId = 1
                },

                new Review
                {
                    Id = 3,
                    Name = "Cold Brew Coffee",
                    Content = "Coffee? yes. Iced or Cold brew coffee? Even better. This stuff right here? The best there is, hands down, nothing else wakes me up faster than this.",
                    CategoryId = 2
                },

                new Review
                {
                    Id = 4,
                    Name = "Shock Energy Drink",
                    Content = "Feel it withing 15 minutes of drinkning it, fantastic for body building and tastes GREAT!!!!",
                    CategoryId = 2
                }
            
            );
        }

    }
}
