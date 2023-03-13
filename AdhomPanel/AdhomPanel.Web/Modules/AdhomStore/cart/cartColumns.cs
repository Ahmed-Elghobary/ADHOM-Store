using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdhomPanel.AdhomStore.Columns
{
    [ColumnsScript("AdhomStore.cart")]
    [BasedOnRow(typeof(cartRow), CheckNames = true)]
    public class cartColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string UserId { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
    }
}