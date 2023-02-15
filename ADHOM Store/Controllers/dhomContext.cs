using ADHOM_Store.Models;

namespace ADHOM_Store.Controllers
{
    internal class dhomContext
    {
        public static implicit operator dhomContext(AdhomContext v)
        {
            throw new NotImplementedException();
        }
    }
}