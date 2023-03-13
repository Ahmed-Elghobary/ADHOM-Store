using Serenity.ComponentModel;
using Serenity.Web;

namespace AdhomPanel.AdhomStore.Forms
{
    [FormScript("AdhomStore.category")]
    [BasedOnRow(typeof(categoryRow), CheckNames = true)]
    public class categoryForm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}