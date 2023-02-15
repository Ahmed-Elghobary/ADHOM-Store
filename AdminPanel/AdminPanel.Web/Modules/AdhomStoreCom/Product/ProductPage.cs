using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.AdhomStoreCom.Pages 
{

    [PageAuthorize(typeof(ProductRow))]
    public class ProductController : Controller
    {
        [Route("AdhomStoreCom/Product")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStoreCom/Product/ProductPage",
                ProductRow.Fields.PageTitle());
        }
    }
}