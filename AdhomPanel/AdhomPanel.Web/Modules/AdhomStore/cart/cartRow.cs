using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdhomPanel.AdhomStore
{
    [ConnectionKey("Adham"), Module("AdhomStore"), TableName("[dbo].[Cart]")]
    [DisplayName("Cart"), InstanceName("Cart")]
    [ReadPermission("cart")]
    [ModifyPermission("cart")]
    public sealed class cartRow : Row<cartRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("User Id"), QuickSearch, NameProperty]
        public string UserId
        {
            get => fields.UserId[this];
            set => fields.UserId[this] = value;
        }

        [DisplayName("Product"), ForeignKey("[dbo].[Product]", "Id"), LeftJoin("jProduct"), TextualField("ProductName")]
        public int? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Qty")]
        public int? Qty
        {
            get => fields.Qty[this];
            set => fields.Qty[this] = value;
        }

        [DisplayName("Product Name"), Expression("jProduct.[Name]")]
        public string ProductName
        {
            get => fields.ProductName[this];
            set => fields.ProductName[this] = value;
        }

        [DisplayName("Product Description"), Expression("jProduct.[Description]")]
        public string ProductDescription
        {
            get => fields.ProductDescription[this];
            set => fields.ProductDescription[this] = value;
        }

        [DisplayName("Product Price"), Expression("jProduct.[Price]")]
        public decimal? ProductPrice
        {
            get => fields.ProductPrice[this];
            set => fields.ProductPrice[this] = value;
        }

        [DisplayName("Product Cat Id"), Expression("jProduct.[CatId]")]
        public int? ProductCatId
        {
            get => fields.ProductCatId[this];
            set => fields.ProductCatId[this] = value;
        }

        [DisplayName("Product Image"), Expression("jProduct.[Image]")]
        public string ProductImage
        {
            get => fields.ProductImage[this];
            set => fields.ProductImage[this] = value;
        }

        [DisplayName("Product Type"), Expression("jProduct.[Type]")]
        public string ProductType
        {
            get => fields.ProductType[this];
            set => fields.ProductType[this] = value;
        }

        [DisplayName("Product Supllier Name"), Expression("jProduct.[SupllierName]")]
        public string ProductSupllierName
        {
            get => fields.ProductSupllierName[this];
            set => fields.ProductSupllierName[this] = value;
        }

        [DisplayName("Product Entry Date"), Expression("jProduct.[EntryDate]")]
        public DateTime? ProductEntryDate
        {
            get => fields.ProductEntryDate[this];
            set => fields.ProductEntryDate[this] = value;
        }

        [DisplayName("Product Review Url"), Expression("jProduct.[ReviewUrl]")]
        public string ProductReviewUrl
        {
            get => fields.ProductReviewUrl[this];
            set => fields.ProductReviewUrl[this] = value;
        }

        [DisplayName("Product Qty"), Expression("jProduct.[Qty]")]
        public int? ProductQty
        {
            get => fields.ProductQty[this];
            set => fields.ProductQty[this] = value;
        }

        public cartRow()
            : base()
        {
        }

        public cartRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField UserId;
            public Int32Field ProductId;
            public Int32Field Qty;

            public StringField ProductName;
            public StringField ProductDescription;
            public DecimalField ProductPrice;
            public Int32Field ProductCatId;
            public StringField ProductImage;
            public StringField ProductType;
            public StringField ProductSupllierName;
            public DateTimeField ProductEntryDate;
            public StringField ProductReviewUrl;
            public Int32Field ProductQty;
        }
    }
}