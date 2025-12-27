using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ARPaymentModel : BaseModel
    {
        public int ID { get; set; }

        public int AccountReceivableID { get; set; }

        public int AccountReceivableTransID { get; set; }

        public int FolioID { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionCode { get; set; } 

        public string Description { get; set; } 

        public decimal Amount { get; set; }

        public string CurrencyID { get; set; } 

        public int ShiftID { get; set; }

        public string CreatedBy { get; set; } 

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int PayInvoice { get; set; }

        public string CashierNo { get; set; } 

        public int OriginShiftID { get; set; }

        public bool IsTransfer { get; set; }
    }
}

