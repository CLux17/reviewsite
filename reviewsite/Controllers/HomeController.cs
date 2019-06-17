using reviewsite.Model;
using reviewsite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ProductRepository productRepo = new ProductRepository();

            var model = productRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            ProductRepository productRepo = new ProductRepository();

            var model = productRepo.GetById(id);

            return View(model);
        }
    }
}
