using Serenity.Services;

namespace AdhomPanel.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}