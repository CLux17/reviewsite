using reviewsite.Model;
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
            throw new NotImplementedException(); //return //productList.ToList();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException(); //return productList.Single(c => c.Id == id);
        }




    }
}
