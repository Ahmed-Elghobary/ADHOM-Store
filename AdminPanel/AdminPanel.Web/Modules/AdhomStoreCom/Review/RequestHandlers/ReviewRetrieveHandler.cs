using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.AdhomStoreCom.ReviewRow>;
using MyRow = AdminPanel.AdhomStoreCom.ReviewRow;

namespace AdminPanel.AdhomStoreCom
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