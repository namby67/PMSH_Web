using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class PropertyModel : BaseModel
    {
        public int ID { get; set; }
        public int PropertyTypeID { get; set; }
        public string PropertyCode { get; set; }
        public string PropertyName { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Inactive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Override cho BaseModel
        public override string GetTableName()
        {
            return "Property";
        }

        public override string GetPrimaryKeyName()
        {
            return "ID";
        }
    }
}
