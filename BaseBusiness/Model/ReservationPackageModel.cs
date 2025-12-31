using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationPackageModel : BaseModel
    {
        public int ID { get; set; }

        public int ReservationID { get; set; }
        public int PackageID { get; set; }
        public int PackageDetailID { get; set; }
        public int RateCodeID { get; set; }

        public string TransactionCode { get; set; }
        public string ArticlesCode { get; set; }
        public string Description { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int Excluded { get; set; }
        public string CurrencyID { get; set; }

        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public int PostingRhythmID { get; set; }
        public DateTime PostingDate { get; set; }
        public string PostingDay { get; set; }

        public int CalculationRuleID { get; set; }
        public int ProfitCenterID { get; set; }

        public decimal PriceAfterTax { get; set; }
        public bool IsTaxInclude { get; set; }

        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }

        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
