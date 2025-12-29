using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationAmountByCurrencyModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public int ConfirmationNo { get; set; }
        public string CurrencyID { get; set; }
        public decimal AmountBeforTax { get; set; }
        public decimal AmountAfterTax { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
