using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationFixedChargeModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public string TransactionCode { get; set; }
        public string ArticlesCode { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyID { get; set; }
        public int PostingRhythmID { get; set; }
        public DateTime PostingDate { get; set; }
        public string PostingDay { get; set; }
        public string Description { get; set; }
        public int ProfitCenterID { get; set; }
        public decimal AmountAfterTax { get; set; }
        public bool IsTaxInclude { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
