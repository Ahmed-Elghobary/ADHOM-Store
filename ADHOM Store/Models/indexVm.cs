namespace ADHOM_Store.Models
{
    public class indexVm
    {

        public indexVm()
        {
            CategoriesVm = new List<Category>();
            ProductsVm = new List<Product>();
            ReviewsVm = new List<Review>();
            LatestProduct = new List<Product>();
        }
       
        public List<Category> CategoriesVm { get; set; }
        public List<Product> ProductsVm { get; set; }
        public List<Product> LatestProduct { get; set; }
        public List<Review> ReviewsVm { get; set; }
    }
}
