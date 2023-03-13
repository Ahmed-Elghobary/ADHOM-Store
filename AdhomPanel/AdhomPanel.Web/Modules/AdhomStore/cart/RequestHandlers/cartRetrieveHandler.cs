using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdhomPanel.AdhomStore.cartRow>;
using MyRow = AdhomPanel.AdhomStore.cartRow;

namespace AdhomPanel.AdhomStore
{
    public interface IcartRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class cartRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IcartRetrieveHandler
    {
        public cartRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}