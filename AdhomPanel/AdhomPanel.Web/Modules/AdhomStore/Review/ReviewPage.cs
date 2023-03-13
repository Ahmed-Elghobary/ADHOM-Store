using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdhomPanel.AdhomStore.Pages 
{

    [PageAuthorize(typeof(ReviewRow))]
    public class ReviewController : Controller
    {
        [Route("AdhomStore/Review")]
        public ActionResult Index()
        {
            return this.GridPage("@/AdhomStore/Review/ReviewPage",
                ReviewRow.Fields.PageTitle());
        }
    }
}