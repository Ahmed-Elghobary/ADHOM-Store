using System;
using System.Collections.Generic;

namespace ADHOM_Store.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
