using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class DepositPaymentModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public int DepositRsqID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionCode { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public string Supplement { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyID { get; set; }
        public decimal AmountMaster { get; set; }
        public string CurrencyMaster { get; set; }
        public bool IsProcess { get; set; }
        public string ReceiptNo { get; set; }
        public bool IsMasterFolio { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string CashierNo { get; set; }
        public int ShiftID { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int ReservationTypeID { get; set; }
        public string PaymentCode { get; set; }
        public bool IsTransfer { get; set; }
    }
}
