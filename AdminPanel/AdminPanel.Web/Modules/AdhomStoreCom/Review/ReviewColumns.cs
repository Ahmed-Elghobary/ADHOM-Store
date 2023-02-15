using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel.AdhomStoreCom.Columns
{
    [ColumnsScript("AdhomStoreCom.Review")]
    [BasedOnRow(typeof(ReviewRow), CheckNames = true)]
    public class ReviewColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}