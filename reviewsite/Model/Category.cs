﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual List<Product> Products { get; set; }
       
    }
}
