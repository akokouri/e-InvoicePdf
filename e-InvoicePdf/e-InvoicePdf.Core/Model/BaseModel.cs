using SQLite.Net.Attributes;

namespace e_InvoicePdf.Core.Model
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}
