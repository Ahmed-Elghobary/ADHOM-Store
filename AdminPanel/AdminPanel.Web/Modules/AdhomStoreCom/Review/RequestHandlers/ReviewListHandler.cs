using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.AdhomStoreCom.ReviewRow>;
using MyRow = AdminPanel.AdhomStoreCom.ReviewRow;

namespace AdminPanel.AdhomStoreCom
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