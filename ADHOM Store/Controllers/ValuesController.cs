using ADHOM_Store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ADHOM_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        AdhomContext db = new AdhomContext();
        public IActionResult Index()
        {
            var o_k = db.Products.Include(x=>x.Cat).Select(
                x => new
                {
                    x.Id,  
                    x.Name,
                    x.Qty,
                    x.Price,
                    catname=x.Cat==null?"":x.Name
                    
                }
                
                ).ToList();
            return Ok(o_k);
        }
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            var o_k = db.Products.ToList();
            return Ok(o_k);
        }
    }
}
