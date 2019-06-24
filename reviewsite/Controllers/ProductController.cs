using Microsoft.AspNetCore.Mvc;
using reviewsite.Model;
using reviewsite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite.Controllers
{
    public class ProductController : Controller
    {
        IRepository<Product> productRepo;

        public ProductController(IRepository<Product> productRepo)
        {
            this.productRepo = productRepo;
        }

        public ViewResult Details()
        {
            var model = productRepo.GetAll();
            return View(model);
        }

        public ViewResult Index(int id)
        {
            var model = productRepo.GetById(id);
            return View(model);
        }
    }
}
