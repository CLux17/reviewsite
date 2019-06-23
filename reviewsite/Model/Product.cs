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
        public string Description { get; set; }
        public string Image { get; set; }
        public string Review { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        //public Product(int id, string name, string review, string description, string image)
        //{
        //    Id = id;
        //    Name = name;
        //    Review = review;
        //    Description = description;
        //    Image = image;

        //}




    }
}
