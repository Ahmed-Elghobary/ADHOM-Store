﻿using ADHOM_Store.Data;
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
        ApplicationDbContext _Usdb;
        UserManager<IdentityUser> _usermanger;
        RoleManager<IdentityRole> _role;
        public HomeController(UserManager<IdentityUser> user, RoleManager<IdentityRole> role, ApplicationDbContext Usdb)
        {
            _usermanger = user;
            _role = role;
            _Usdb = Usdb;
        }
        public IActionResult Index()
        {

            indexVm Result = new indexVm();

            Result.CategoriesVm = db.Categories.ToList();
            Result.ProductsVm = db.Products.ToList();
            Result.ReviewsVm = db.Reviews.ToList();
            Result.LatestProduct = db.Products.OrderByDescending(x => x.EntryDate).Take(4).ToList();
            return View(Result);
        }


        //[Authorize(Roles = "admin")]
        public IActionResult Privacy()
        {
            //var user = _usermanger.Users.ToList();
            //_role.CreateAsync(new IdentityRole { });
            var Role = _role.Roles.ToList();

            return View(Role);
        }


       public  async Task< IActionResult> addRole(string userId,string roleName)
        {
            var _user =await _usermanger.FindByIdAsync(userId);
            var result = await _usermanger.AddToRoleAsync(_user, roleName);
            if (!result.Succeeded)
            {
                 await _usermanger.RemoveFromRoleAsync(_user, roleName);
            }
            return RedirectToAction("UserRoles");
        }
        public async Task<IActionResult> UserRoles()
        {
            //User
            var _user = _usermanger.Users.ToList();

            List<UserVm> result = new List<UserVm>();
            foreach (var item in _user)
            {
                //Role
                var Rs = await _usermanger.GetRolesAsync(item);
                result.Add(new UserVm { User = item, UserRole = (List<string>)Rs });
            }
            ViewBag.AllRoles = _role.Roles.ToList();

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Role(RoleVm model)
        {
            //var Role = _role.Roles.ToList();
            await _role.CreateAsync(new IdentityRole { Name = model.roleName });

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Cart()
        {
            //await _role.CreateAsync(new IdentityRole { Name = "Admin" });
            //await _role.CreateAsync(new IdentityRole { Name = "SupAdmin" });
            //await _role.CreateAsync(new IdentityRole { Name = "Sales" });

            if (_Usdb.Roles.FirstOrDefault(x => x.Name == "admon") == null)
            {
                _Usdb.Roles.Add(new IdentityRole { Name = "admon" });
                _Usdb.SaveChanges();
            }

            return View();
        }

        public IActionResult product(int id)
        {

            var product = db.Products.Where(x => x.CatId == id).ToList();
            return View(product);
        }


        public IActionResult CurrentProduct(int id)
        {

            var productFind = db.Products.Include(x => x.Cat).Include(x => x.ProductImages).FirstOrDefault(x => x.Id == id);
            return View(productFind);
        }


        [HttpGet]
        public IActionResult product_Search(string Xname)
        {
            var products = new List<Product>();
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

            db.Reviews.Add(new Review { Name = model.Name, Email = model.Email, Subject = model.Subject, Description = model.Description });
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Categories()
        {

            var cats = db.Categories.ToList();
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