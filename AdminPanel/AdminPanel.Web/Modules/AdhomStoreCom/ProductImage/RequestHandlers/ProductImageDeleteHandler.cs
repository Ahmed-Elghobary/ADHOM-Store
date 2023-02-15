using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.AdhomStoreCom.ProductImageRow;

namespace AdminPanel.AdhomStoreCom
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