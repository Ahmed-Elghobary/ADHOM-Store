using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdhomPanel.AdhomStore
{
    [ConnectionKey("Adham"), Module("AdhomStore"), TableName("[dbo].[Product]")]
    [DisplayName("Product"), InstanceName("Product")]
    [ReadPermission("product")]
    [ModifyPermission("product")]

    [LookupScript]
    public sealed class productRow : Row<productRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Description")]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Price"), Size(18)]
        public decimal? Price
        {
            get => fields.Price[this];
            set => fields.Price[this] = value;
        }

        [DisplayName("Cat"), ForeignKey("[dbo].[Category]", "Id"), LeftJoin("jCat"), TextualField("CatName")]
        [LookupEditor(typeof(categoryRow))]
        public int? CatId
        {
            get => fields.CatId[this];
            set => fields.CatId[this] = value;
        }

        [DisplayName("Image"),ImageUploadEditor]
        public string Image
        {
            get => fields.Image[this];
            set => fields.Image[this] = value;
        }

        [DisplayName("Type"), Size(50)]
        public string Type
        {
            get => fields.Type[this];
            set => fields.Type[this] = value;
        }

        [DisplayName("Supllier Name")]
        public string SupllierName
        {
            get => fields.SupllierName[this];
            set => fields.SupllierName[this] = value;
        }

        [DisplayName("Entry Date")]
        public DateTime? EntryDate
        {
            get => fields.EntryDate[this];
            set => fields.EntryDate[this] = value;
        }

        [DisplayName("Review Url")]
        public string ReviewUrl
        {
            get => fields.ReviewUrl[this];
            set => fields.ReviewUrl[this] = value;
        }

        [DisplayName("Qty")]
        public int? Qty
        {
            get => fields.Qty[this];
            set => fields.Qty[this] = value;
        }

        [DisplayName("Cat Name"), Expression("jCat.[Name]")]
        public string CatName
        {
            get => fields.CatName[this];
            set => fields.CatName[this] = value;
        }

        [DisplayName("Cat Description"), Expression("jCat.[Description]")]
        public string CatDescription
        {
            get => fields.CatDescription[this];
            set => fields.CatDescription[this] = value;
        }

        [DisplayName("Cat Image"), Expression("jCat.[Image]")]
        public string CatImage
        {
            get => fields.CatImage[this];
            set => fields.CatImage[this] = value;
        }

        public productRow()
            : base()
        {
        }

        public productRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
            public DecimalField Price;
            public Int32Field CatId;
            public StringField Image;
            public StringField Type;
            public StringField SupllierName;
            public DateTimeField EntryDate;
            public StringField ReviewUrl;
            public Int32Field Qty;

            public StringField CatName;
            public StringField CatDescription;
            public StringField CatImage;
        }
    }
}