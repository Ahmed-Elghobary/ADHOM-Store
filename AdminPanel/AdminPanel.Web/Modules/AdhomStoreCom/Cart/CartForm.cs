using Serenity.ComponentModel;
using Serenity.Web;

namespace AdminPanel.AdhomStoreCom.Forms
{
    [FormScript("AdhomStoreCom.Cart")]
    [BasedOnRow(typeof(CartRow), CheckNames = true)]
    public class CartForm
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}