using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class CurrencyModel : BaseModel
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public bool MasterStatus { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate {get;set;}
        public DateTime UpdateDate { get; set; }
        public int UserUpdateID { get; set; }
        public string TransactionCode { get; set; }
        public bool IsShow { get; set; }
        public bool Inactive { get;set; }
        public int Decimals { get;set; }
        public bool IsSynchronous { get; set; }
        public override string GetStringID()
        {
            return ID;
        }

        public override string GetPrimaryKeyName()
        {
            return "ID";
        }
    }
}
