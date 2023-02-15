using Serenity.Services;
using MyRequest = AdminPanel.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.Administration.UserRow>;
using MyRow = AdminPanel.Administration.UserRow;

namespace AdminPanel.Administration
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