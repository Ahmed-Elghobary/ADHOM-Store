using Serenity.Services;
using MyRequest = AdhomPanel.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<AdhomPanel.Administration.UserRow>;
using MyRow = AdhomPanel.Administration.UserRow;

namespace AdhomPanel.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}