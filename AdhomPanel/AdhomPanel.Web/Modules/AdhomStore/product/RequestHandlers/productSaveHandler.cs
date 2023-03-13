using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdhomPanel.AdhomStore.productRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdhomPanel.AdhomStore.productRow;

namespace AdhomPanel.AdhomStore
{
    public interface IproductSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class productSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IproductSaveHandler
    {
        public productSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}