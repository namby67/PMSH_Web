using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ARAccountTypeModel : BaseModel
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal CreditLimit { get; set; }
        public string CurrencyID { get; set; }
        public string StatementMode { get;set; }
        public string ReminderCycle { get; set; }
        public int DayOfMonth { get; set; }
        public int DayOrderThan { get; set; }
        public decimal Amount { get; set; }
        public decimal Percentage { get; set; }
        public bool IncludePayment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
    }
}
