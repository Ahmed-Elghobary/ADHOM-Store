using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdhomPanel.AdhomStore.cartRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdhomPanel.AdhomStore.cartRow;

namespace AdhomPanel.AdhomStore
{
    public interface IcartSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class cartSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IcartSaveHandler
    {
        public cartSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}