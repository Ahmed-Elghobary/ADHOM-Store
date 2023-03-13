using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdhomPanel.AdhomStore.cartRow>;
using MyRow = AdhomPanel.AdhomStore.cartRow;

namespace AdhomPanel.AdhomStore
{
    public interface IcartListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class cartListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IcartListHandler
    {
        public cartListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}