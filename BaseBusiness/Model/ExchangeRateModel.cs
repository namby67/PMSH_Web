using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class ExchangeRateModel : BaseModel
    {
        public int ID { get; set; }

        public DateTime? DateTime { get; set; }

        public string FromCurrencyID { get; set; }
        public string ToCurrencyID { get; set; }

        public decimal? ExChangeRate { get; set; }
        public decimal? ExChangeRateSell { get; set; }

        public decimal? ExChangeRateMax { get; set; }
        public int? DenominationMax { get; set; }

        public decimal? ExChangeRateMedium { get; set; }
        public int? DenominationMedium { get; set; }

        public decimal? ExChangeRateMin { get; set; }
        public int? DenominationMin { get; set; }

        public int? UserInsertID { get; set; }
        public DateTime? CreateDate { get; set; }

        public int? UserUpdateID { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
