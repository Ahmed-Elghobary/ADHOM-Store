using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdhomPanel.AdhomStore.Pages 
{

    [PageAuthorize(typeof(productRow))]
    public class productController : Controller
    {
        [Route("AdhomStore/product")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStore/product/productPage",
                productRow.Fields.PageTitle());
        }
    }
}