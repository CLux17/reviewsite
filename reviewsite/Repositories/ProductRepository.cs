﻿using reviewsite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace reviewsite.Repositories
{
    public class ProductRepository : IRepository<Product>
    {


        private SiteContext db;

        public ProductRepository(SiteContext db)
        {
            this.db = db;
        }


        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.Single(c => c.Id == id);
        }

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }


    }
}
