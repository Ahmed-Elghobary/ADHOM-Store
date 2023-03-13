using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdhomPanel.AdhomStore.ProductImageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdhomPanel.AdhomStore.ProductImageRow;

namespace AdhomPanel.AdhomStore
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