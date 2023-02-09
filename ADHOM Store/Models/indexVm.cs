namespace ADHOM_Store.Models
{
    public class indexVm
    {

        public indexVm()
        {
            CategoriesVm = new List<Category>();
            ProductsVm= new List<Product>();  
            ReviewsVm= new List<Review>();
        }
       
        public List<Category> CategoriesVm { get; set; }
        public List<Product> ProductsVm { get; set; }
        public List<Review> ReviewsVm { get; set; }
    }
}
