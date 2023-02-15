using Serenity.Navigation;
using MyPages = AdminPanel.AdhomStoreCom.Pages;

[assembly: NavigationLink(int.MaxValue, "AdhomStoreCom/Category", typeof(MyPages.CategoryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AdhomStoreCom/Cart", typeof(MyPages.CartController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AdhomStoreCom/Product", typeof(MyPages.ProductController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AdhomStoreCom/Product Image", typeof(MyPages.ProductImageController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AdhomStoreCom/Review", typeof(MyPages.ReviewController), icon: null)]