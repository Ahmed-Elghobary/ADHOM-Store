using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.AdhomStoreCom.Pages 
{

    [PageAuthorize(typeof(CartRow))]
    public class CartController : Controller
    {
        [Route("AdhomStoreCom/Cart")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStoreCom/Cart/CartPage",
                CartRow.Fields.PageTitle());
        }
    }
}