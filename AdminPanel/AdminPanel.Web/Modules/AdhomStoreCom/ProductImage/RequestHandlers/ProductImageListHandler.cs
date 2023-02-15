using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.AdhomStoreCom.ProductImageRow>;
using MyRow = AdminPanel.AdhomStoreCom.ProductImageRow;

namespace AdminPanel.AdhomStoreCom
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