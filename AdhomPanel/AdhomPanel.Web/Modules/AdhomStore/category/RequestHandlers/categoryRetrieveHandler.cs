using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdhomPanel.AdhomStore.categoryRow>;
using MyRow = AdhomPanel.AdhomStore.categoryRow;

namespace AdhomPanel.AdhomStore
{
    public interface IcategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class categoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryRetrieveHandler
    {
        public categoryRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}