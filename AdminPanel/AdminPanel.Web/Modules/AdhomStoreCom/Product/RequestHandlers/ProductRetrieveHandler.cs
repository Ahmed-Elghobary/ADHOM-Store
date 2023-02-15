using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.AdhomStoreCom.ProductRow>;
using MyRow = AdminPanel.AdhomStoreCom.ProductRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface IProductRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductRetrieveHandler
    {
        public ProductRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}