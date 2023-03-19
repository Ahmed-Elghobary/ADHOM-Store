using Microsoft.AspNetCore.Identity;

namespace ADHOM_Store.Models
{
   

    public class UserVm
    {


        public UserVm()
        {
            UserRole = new List<string>();
        }


        public IdentityUser User { get; set; }
        public List<string> UserRole { get; set; }


      
    }
}
