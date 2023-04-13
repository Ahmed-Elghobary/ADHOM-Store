using ADHOM_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ADHOM_Store.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            adhomContext db = new adhomContext();
           var list= db.Categories.Select(x => new {x.Id, x.Name});
            ViewBag.catlist = new SelectList(list, "Id", "Name");
            return View();
        }

        public IActionResult Charts()
        {
            return View();
        }

        //https://localhost:7035/Product/getAllProduct
        public IActionResult getAllProduct()
        {
            adhomContext db = new adhomContext();
          var o_k=  db.Products.Select(x => new { x.Name, x.Price, x.Qty }).ToList();
            return Ok(o_k);
        }

        [HttpPost]
        public IActionResult Create(ProductVm model)
        {
            
            if (ModelState.IsValid)
            {
                adhomContext db = new adhomContext();
                Category  c= new Category ();
                c.Name = model.CatName_Vm;
                db.Categories.Add(c);
                db.Products.Add(new Product
                {
                    Name = model.ProductName_Vm,
                    Price = model.ProductPrice_Vm,
                    Qty = model.ProductQt_Vm,
                    Cat = c
                }); 
                db.SaveChanges();
                return View("Index");

            }
            return View("Index", model);
        }
    }
}
