using Serenity.ComponentModel;
using Serenity.Web;

namespace AdhomPanel.AdhomStore.Forms
{
    [FormScript("AdhomStore.ProductImage")]
    [BasedOnRow(typeof(ProductImageRow), CheckNames = true)]
    public class ProductImageForm
    {
        public int ProductId { get; set; }
        public string Image { get; set; }
    }
}