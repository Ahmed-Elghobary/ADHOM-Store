using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace AdhomPanel.AdhomStore.Forms
{
    [FormScript("AdhomStore.product")]
    [BasedOnRow(typeof(productRow), CheckNames = true)]
    public class productForm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CatId { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string SupllierName { get; set; }
        public DateTime EntryDate { get; set; }
        public string ReviewUrl { get; set; }
        public int Qty { get; set; }
    }
}