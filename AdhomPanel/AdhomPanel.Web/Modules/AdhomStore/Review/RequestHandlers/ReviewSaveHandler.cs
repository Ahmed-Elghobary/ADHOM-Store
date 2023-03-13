using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdhomPanel.AdhomStore.ReviewRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdhomPanel.AdhomStore.ReviewRow;

namespace AdhomPanel.AdhomStore
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