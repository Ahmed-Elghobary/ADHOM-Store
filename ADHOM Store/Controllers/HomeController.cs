﻿using ADHOM_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ADHOM_Store.Controllers
{
    public class HomeController : Controller
    {
        AdhomContext db = new AdhomContext();
        public IActionResult Index()
        {

            indexVm Result = new indexVm();
            
            Result.CategoriesVm = db.Categories.ToList();
            Result.ProductsVm=db.Products.ToList();
            Result.ReviewsVm=db.Reviews.ToList();
            return View(Result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult product(int id)
        {
            
           var product= db.Products.Where(x=>x.CatId==id).ToList();
            return View(product);
        }


        public IActionResult CurrentProduct(int id)
        {

            var productFind = db.Products.Include(x=>x.Cat).Include(x => x.ProductImages).FirstOrDefault(x=>x.Id == id);
            return View(productFind);
        }


        [HttpGet]
        public IActionResult product_Search(string Xname)
        {
            var products=new List<Product>();
            if (string.IsNullOrEmpty(Xname))
            {
                products = db.Products.ToList();
            }
            else
            {


                products = db.Products.Where(x => x.Name.Contains(Xname)).ToList();
            
            }
            return View(products);
        }

        [HttpPost]
        public IActionResult sendReview(Review model)
        {

             db.Reviews.Add(new Review { Name=model.Name,Email=model.Email,Subject=model.Subject,Description=model.Description});
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Categories()
        {
           
           var cats= db.Categories.ToList();
            return View(cats);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}