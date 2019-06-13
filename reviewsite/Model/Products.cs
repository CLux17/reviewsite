using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite.Model
{
    public class Products
    {
        public class Product
        {
            public int Id;
            public string Name;
            public string Category;


            public Product(int id, string name, string category)
            {
                Id = id;
                Name = name;
                Category = category;
            }
        }

        Dictionary <int, string> products;

    }
}
