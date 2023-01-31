using System;
using System.Collections.Generic;

namespace ADHOM_Store.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }

        public virtual Product? Product { get; set; }
    }
}
