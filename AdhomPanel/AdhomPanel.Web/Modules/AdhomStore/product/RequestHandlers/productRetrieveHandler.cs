using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdhomPanel.AdhomStore.productRow>;
using MyRow = AdhomPanel.AdhomStore.productRow;

namespace AdhomPanel.AdhomStore
{
    public interface IproductRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class productRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IproductRetrieveHandler
    {
        public productRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}