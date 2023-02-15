using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.AdhomStoreCom.CartRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.AdhomStoreCom.CartRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface ICartSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CartSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICartSaveHandler
    {
        public CartSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}