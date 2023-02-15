using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.AdhomStoreCom.CategoryRow>;
using MyRow = AdminPanel.AdhomStoreCom.CategoryRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface ICategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryRetrieveHandler
    {
        public CategoryRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}