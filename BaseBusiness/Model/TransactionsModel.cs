using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
namespace BaseBusiness.Model
{
    public class TransactionsModel : BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string OldCode { get; set; }
        public string AdjustmentCode { get; set; }
        public string Description { get; set; }
        public int TransactionGroupID { get; set; }
        public string GroupCode { get; set; }
        public int TransactionSubGroupID { get; set; }
        public string SubgroupCode { get; set; }
        public int GroupType { get; set; }
        public int GenerateID { get; set; }
        public decimal DefaultPrice { get; set; }
        public string CurrencyID { get; set; }
        public int TransactionType { get; set; }
        public bool ManualPosting { get; set; }
        public bool Paidout { get; set; }
        public bool FOPayments { get; set; }
        public bool ARPayments { get; set; }
        public bool DepositPayments { get; set; }
        public int PaymentType { get; set; }
        public bool IsActive { get; set; }
        public bool TaxInclude { get; set; }
        public bool RevenueGroup { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public int VatTypeID { get; set; }
        public string ARNo { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
