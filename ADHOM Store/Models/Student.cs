using System;
using System.Collections.Generic;

namespace ADHOM_Store.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
