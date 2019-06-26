using Microsoft.AspNetCore.Mvc;
using reviewsite.Model;
using reviewsite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewsite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("~/Product/Details/Model.productId");
        }

    }
}

    


