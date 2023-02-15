using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.AdhomStoreCom.CategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.AdhomStoreCom.CategoryRow;

namespace AdminPanel.AdhomStoreCom
{
    public interface ICategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategorySaveHandler
    {
        public CategorySaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}