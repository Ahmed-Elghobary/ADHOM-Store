using ADHOM_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ADHOM_Store.Controllers
{
    public class HomeController : Controller
    {
        AdhomContext db = new AdhomContext();
        public IActionResult Index()
        {
            
            var cats = db.Categories.ToList();
            ViewBag.prod=db.Products.ToList();
            return View(cats);
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


        [HttpGet]
        public IActionResult product_Search(string Xname)
        {

            var product = db.Products.Where(x => x.Name.Contains(Xname)).ToList();
            return View(product);
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