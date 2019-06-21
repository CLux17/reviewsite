using reviewsite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {

        private SiteContext db;

        public CategoryRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(c => c.Id == id);
        }
    }
}