using Serenity.ComponentModel;
using Serenity.Web;

namespace AdminPanel.AdhomStoreCom.Forms
{
    [FormScript("AdhomStoreCom.ProductImage")]
    [BasedOnRow(typeof(ProductImageRow), CheckNames = true)]
    public class ProductImageForm
    {
        public int ProductId { get; set; }
        public string Image { get; set; }
    }
}