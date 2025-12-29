using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class DepositRuleModel : BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public decimal AmountValue { get; set; }
        public string CurrencyID { get; set; }
        public int DaysBeforeArrival { get; set; }
        public int DaysAfterBooking { get; set; }
        public int Sequence { get; set; }
        public bool Inactive { get;set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get;set; }
    }
}
