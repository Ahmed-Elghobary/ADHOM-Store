using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdhomPanel.AdhomStore.ProductImageRow>;
using MyRow = AdhomPanel.AdhomStore.ProductImageRow;

namespace AdhomPanel.AdhomStore
{
    public interface IProductImageListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductImageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageListHandler
    {
        public ProductImageListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}