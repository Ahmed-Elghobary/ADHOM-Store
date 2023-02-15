using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.AdhomStoreCom.CartRow>;
using MyRow = AdminPanel.AdhomStoreCom.CartRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface ICartListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CartListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICartListHandler
    {
        public CartListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}