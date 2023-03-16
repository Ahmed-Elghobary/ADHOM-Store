using ADHOM_Store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ADHOM_Store.Controllers
{
    public class HomeController : Controller
    {
        AdhomContext db = new AdhomContext();
        UserManager<IdentityUser> _usermanger;
        RoleManager<IdentityRole> _role;
        public HomeController(UserManager<IdentityUser> user, RoleManager<IdentityRole> role)
        {
            _usermanger = user;
            _role = role;
        }
        public IActionResult Index()
        {

            indexVm Result = new indexVm();
            
            Result.CategoriesVm = db.Categories.ToList();
            Result.ProductsVm=db.Products.ToList();
            Result.ReviewsVm=db.Reviews.ToList();
            Result.LatestProduct = db.Products.OrderByDescending(x=>x.EntryDate).Take(4).ToList();
            return View(Result);
        }
        [Authorize]
        public IActionResult Privacy()
        {
            var user = _usermanger.Users.ToList();
            return View(user);
        }

        public IActionResult Role()
        {
            var Role = _role.Roles.ToList();
            return View(Role);
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
            ViewBag.isAdmin = true;
            return View(cats);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}