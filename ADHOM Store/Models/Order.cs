using System;
using System.Collections.Generic;

namespace ADHOM_Store.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Userid { get; set; }
    }
}
