using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdhomPanel.AdhomStore.Pages 
{

    [PageAuthorize(typeof(cartRow))]
    public class cartController : Controller
    {
        [Route("AdhomStore/cart")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStore/cart/cartPage",
                cartRow.Fields.PageTitle());
        }
    }
}