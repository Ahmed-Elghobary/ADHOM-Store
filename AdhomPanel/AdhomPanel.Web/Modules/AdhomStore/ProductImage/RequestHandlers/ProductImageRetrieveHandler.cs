using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdhomPanel.AdhomStore.ProductImageRow>;
using MyRow = AdhomPanel.AdhomStore.ProductImageRow;

namespace AdhomPanel.AdhomStore
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