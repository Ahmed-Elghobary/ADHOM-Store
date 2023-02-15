using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.AdhomStoreCom.ProductRow>;
using MyRow = AdminPanel.AdhomStoreCom.ProductRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface IProductListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductListHandler
    {
        public ProductListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}