using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdhomPanel.AdhomStore.categoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdhomPanel.AdhomStore.categoryRow;

namespace AdhomPanel.AdhomStore
{
    public interface IcategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class categorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IcategorySaveHandler
    {
        public categorySaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}