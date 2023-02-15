using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.AdhomStoreCom.ReviewRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.AdhomStoreCom.ReviewRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface IReviewSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ReviewSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewSaveHandler
    {
        public ReviewSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}