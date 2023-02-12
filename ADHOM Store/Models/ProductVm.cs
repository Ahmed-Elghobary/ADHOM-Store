using System.ComponentModel.DataAnnotations;

namespace ADHOM_Store.Models
{
    public class ProductVm
    {
        [Required]
        [Display(Name ="Category Name")]
        public string CatName_Vm { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName_Vm { get; set; }
        public decimal ProductPrice_Vm { get; set; }

        public int ProductQt_Vm { get; set; }
    }
}
