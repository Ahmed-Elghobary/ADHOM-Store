using Serenity.ComponentModel;
using Serenity.Web;

namespace AdhomPanel.AdhomStore.Forms
{
    [FormScript("AdhomStore.cart")]
    [BasedOnRow(typeof(cartRow), CheckNames = true)]
    public class cartForm
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}