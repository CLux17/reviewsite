﻿using System;
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
        public virtual int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Review> Reviews { get; set; }

        //    public Product(int id, string name, string description, string image, int categoryId)
        //    {
        //        Name = name;
        //        Description = description;
        //        Image = image;
        //    }
        
    }
}
