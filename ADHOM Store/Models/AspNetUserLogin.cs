using System;
using System.Collections.Generic;

namespace ADHOM_Store.Models
{
    public partial class AspNetUserLogin
    {
        public string LoginProvider { get; set; } = null!;
        public string ProviderKey { get; set; } = null!;
        public string? ProviderDisplayName { get; set; }
        public string UserId { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
