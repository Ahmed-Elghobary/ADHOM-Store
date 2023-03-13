using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdhomPanel.AdhomStore.ReviewRow>;
using MyRow = AdhomPanel.AdhomStore.ReviewRow;

namespace AdhomPanel.AdhomStore
{
    public interface IReviewRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ReviewRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewRetrieveHandler
    {
        public ReviewRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}