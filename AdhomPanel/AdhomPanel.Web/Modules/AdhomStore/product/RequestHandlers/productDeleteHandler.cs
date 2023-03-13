using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdhomPanel.AdhomStore.productRow;

namespace AdhomPanel.AdhomStore
{
    public interface IproductDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class productDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IproductDeleteHandler
    {
        public productDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}