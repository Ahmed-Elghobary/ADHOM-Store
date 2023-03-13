using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdhomPanel.AdhomStore.ReviewRow>;
using MyRow = AdhomPanel.AdhomStore.ReviewRow;

namespace AdhomPanel.AdhomStore
{
    public interface IReviewListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ReviewListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IReviewListHandler
    {
        public ReviewListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}