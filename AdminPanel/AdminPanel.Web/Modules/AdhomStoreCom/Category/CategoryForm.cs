using Serenity.ComponentModel;
using Serenity.Web;

namespace AdminPanel.AdhomStoreCom.Forms
{
    [FormScript("AdhomStoreCom.Category")]
    [BasedOnRow(typeof(CategoryRow), CheckNames = true)]
    public class CategoryForm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}