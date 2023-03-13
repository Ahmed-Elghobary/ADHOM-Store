using Serenity.Navigation;
using MyPages = AdhomPanel.AdhomStore.Pages;

[assembly: NavigationLink(int.MaxValue, "AdhomStore/Category", typeof(MyPages.categoryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AdhomStore/Cart", typeof(MyPages.cartController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AdhomStore/Product", typeof(MyPages.productController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AdhomStore/Product Image", typeof(MyPages.ProductImageController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AdhomStore/Review", typeof(MyPages.ReviewController), icon: null)]