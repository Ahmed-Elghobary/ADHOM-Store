using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdhomPanel.AdhomStore.categoryRow;

namespace AdhomPanel.AdhomStore
{
    public interface IcategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class categoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryDeleteHandler
    {
        public categoryDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}