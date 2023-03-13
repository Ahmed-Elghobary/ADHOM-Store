using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdhomPanel.AdhomStore.ProductImageRow;

namespace AdhomPanel.AdhomStore
{
    public interface IProductImageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductImageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageDeleteHandler
    {
        public ProductImageDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}