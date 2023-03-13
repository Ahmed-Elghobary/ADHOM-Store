using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdhomPanel.AdhomStore.Pages 
{

    [PageAuthorize(typeof(ProductImageRow))]
    public class ProductImageController : Controller
    {
        [Route("AdhomStore/ProductImage")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStore/ProductImage/ProductImagePage",
                ProductImageRow.Fields.PageTitle());
        }
    }
}