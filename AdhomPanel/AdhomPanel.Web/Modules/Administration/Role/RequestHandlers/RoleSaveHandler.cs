using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdhomPanel.Administration.RoleRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdhomPanel.Administration.RoleRow;


namespace AdhomPanel.Administration
{
    public interface IRoleSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
    {
        public RoleSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void InvalidateCacheOnCommit()
        {
            base.InvalidateCacheOnCommit();

            Cache.InvalidateOnCommit(UnitOfWork, UserPermissionRow.Fields);
            Cache.InvalidateOnCommit(UnitOfWork, RolePermissionRow.Fields);
        }
    }
}