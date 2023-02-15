using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.AdhomStoreCom.ProductRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.AdhomStoreCom.ProductRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface IProductSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductSaveHandler
    {
        public ProductSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}