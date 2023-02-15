using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace AdminPanel.AdhomStoreCom.Forms
{
    [FormScript("AdhomStoreCom.Product")]
    [BasedOnRow(typeof(ProductRow), CheckNames = true)]
    public class ProductForm
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