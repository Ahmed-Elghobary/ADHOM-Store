using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.AdhomStoreCom.CartRow>;
using MyRow = AdminPanel.AdhomStoreCom.CartRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface ICartRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CartRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICartRetrieveHandler
    {
        public CartRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}