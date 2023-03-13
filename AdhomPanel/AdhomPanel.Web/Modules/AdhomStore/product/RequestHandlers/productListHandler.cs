using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdhomPanel.AdhomStore.productRow>;
using MyRow = AdhomPanel.AdhomStore.productRow;

namespace AdhomPanel.AdhomStore
{
    public interface IproductListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class productListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IproductListHandler
    {
        public productListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}