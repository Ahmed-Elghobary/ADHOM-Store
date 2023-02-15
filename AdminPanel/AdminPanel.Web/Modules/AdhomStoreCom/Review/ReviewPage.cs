using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.AdhomStoreCom.Pages 
{

    [PageAuthorize(typeof(ReviewRow))]
    public class ReviewController : Controller
    {
        [Route("AdhomStoreCom/Review")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStoreCom/Review/ReviewPage",
                ReviewRow.Fields.PageTitle());
        }
    }
}