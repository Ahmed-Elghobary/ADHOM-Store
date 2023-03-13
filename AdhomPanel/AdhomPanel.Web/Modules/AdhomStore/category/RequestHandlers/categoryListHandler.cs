using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdhomPanel.AdhomStore.categoryRow>;
using MyRow = AdhomPanel.AdhomStore.categoryRow;

namespace AdhomPanel.AdhomStore
{
    public interface IcategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class categoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryListHandler
    {
        public categoryListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}