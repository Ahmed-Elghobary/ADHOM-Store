using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.AdhomStoreCom.ProductImageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.AdhomStoreCom.ProductImageRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface IProductImageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductImageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageSaveHandler
    {
        public ProductImageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}