using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdhomPanel.AdhomStore
{
    [ConnectionKey("Adham"), Module("AdhomStore"), TableName("[dbo].[Category]")]
    [DisplayName("Category"), InstanceName("Category")]
    [ReadPermission("category")]
    [ModifyPermission("category")]


    [LookupScript]
    public sealed class categoryRow : Row<categoryRow.RowFields>, IIdRow, INameRow
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

        [DisplayName("Image")]
        public string Image
        {
            get => fields.Image[this];
            set => fields.Image[this] = value;
        }

        public categoryRow()
            : base()
        {
        }

        public categoryRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
            public StringField Image;
        }
    }
}