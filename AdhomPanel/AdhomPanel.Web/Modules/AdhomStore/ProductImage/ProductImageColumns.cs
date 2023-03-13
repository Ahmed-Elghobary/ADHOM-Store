using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdhomPanel.AdhomStore.Columns
{
    [ColumnsScript("AdhomStore.ProductImage")]
    [BasedOnRow(typeof(ProductImageRow), CheckNames = true)]
    public class ProductImageColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string ProductName { get; set; }
        [EditLink]
        public string Image { get; set; }
    }
}