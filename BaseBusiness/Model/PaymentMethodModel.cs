using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class PaymentMethodModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public string TransactionCode { get; set; }
        public string CreditCardNo { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Amount { get; set; }
    }
}
