using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.AdhomStoreCom.Pages 
{

    [PageAuthorize(typeof(ProductImageRow))]
    public class ProductImageController : Controller
    {
        [Route("AdhomStoreCom/ProductImage")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStoreCom/ProductImage/ProductImagePage",
                ProductImageRow.Fields.PageTitle());
        }
    }
}