using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.AdhomStoreCom.Pages 
{

    [PageAuthorize(typeof(CategoryRow))]
    public class CategoryController : Controller
    {
        [Route("AdhomStoreCom/Category")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStoreCom/Category/CategoryPage",
                CategoryRow.Fields.PageTitle());
        }
    }
}