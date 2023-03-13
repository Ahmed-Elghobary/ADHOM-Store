using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace AdhomPanel.AdhomStore.Columns
{
    [ColumnsScript("AdhomStore.product")]
    [BasedOnRow(typeof(productRow), CheckNames = true)]
    public class productColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CatName { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string SupllierName { get; set; }
        public DateTime EntryDate { get; set; }
        public string ReviewUrl { get; set; }
        public int Qty { get; set; }
    }
}