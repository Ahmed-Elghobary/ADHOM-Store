using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdhomPanel.AdhomStore.Pages 
{

    [PageAuthorize(typeof(categoryRow))]
    public class categoryController : Controller
    {
        [Route("AdhomStore/category")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStore/category/categoryPage",
                categoryRow.Fields.PageTitle());
        }
    }
}