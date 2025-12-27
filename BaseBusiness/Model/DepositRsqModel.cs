using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class DepositRsqModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public DateTime RequestDate { get; set; }
        public string Description { get; set; }
        public int ChargeType { get; set; }
        public int DepositRuleID { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyID { get; set; }
        public decimal AmountMaster { get; set; }
        public string CurrencyMaster { get; set; }
        public bool IsMasterFolio { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsAuto { get; set; }
        public int RequestType { get; set; }
        public decimal PaidAmountVND { get; set; }
        public decimal PaidAmountUSD {get;set;}
        public decimal DueAmountVND { get; set; }
        public decimal DueAmountUSD { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal DueAmount { get; set; }
    }
}
