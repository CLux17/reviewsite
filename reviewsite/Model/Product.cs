using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Review { get; set; }

        public Product(int id, string name, string category, string description, string review)
        {
            Id = id;
            Name = name;
            Category = category;
            Description = description;
            Review = review;
        }




    }
}
