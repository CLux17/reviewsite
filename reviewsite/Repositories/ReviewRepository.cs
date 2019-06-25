﻿using reviewsite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite.Repositories
{
    public class ReviewRepository
    {
        private SiteContext db;

        public ReviewRepository(SiteContext db)
        {
            this.db = db;
        }
        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public Review GetById(int id)
        {
            return db.Reviews.Single(c => c.Id == id);
        }

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }
    }
}