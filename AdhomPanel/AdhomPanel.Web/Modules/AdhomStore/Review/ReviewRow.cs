using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdhomPanel.AdhomStore
{
    [ConnectionKey("Adham"), Module("AdhomStore"), TableName("[dbo].[Review]")]
    [DisplayName("Review"), InstanceName("Review")]
    [ReadPermission("Review")]
    [ModifyPermission("Review")]
    public sealed class ReviewRow : Row<ReviewRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(50), QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Email"), Size(50)]
        public string Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("Subject"), Size(50)]
        public string Subject
        {
            get => fields.Subject[this];
            set => fields.Subject[this] = value;
        }

        [DisplayName("Description")]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        public ReviewRow()
            : base()
        {
        }

        public ReviewRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Email;
            public StringField Subject;
            public StringField Description;
        }
    }
}