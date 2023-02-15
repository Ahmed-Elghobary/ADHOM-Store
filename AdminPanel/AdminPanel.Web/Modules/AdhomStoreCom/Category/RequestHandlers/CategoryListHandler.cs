using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.AdhomStoreCom.CategoryRow>;
using MyRow = AdminPanel.AdhomStoreCom.CategoryRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface ICategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryListHandler
    {
        public CategoryListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}