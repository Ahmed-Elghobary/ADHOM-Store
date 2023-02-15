using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.AdhomStoreCom.ProductImageRow>;
using MyRow = AdminPanel.AdhomStoreCom.ProductImageRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface IProductImageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductImageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageRetrieveHandler
    {
        public ProductImageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}