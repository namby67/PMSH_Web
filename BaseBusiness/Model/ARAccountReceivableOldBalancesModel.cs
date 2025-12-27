using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public  class ARAccountReceivableOldBalancesModel : BaseModel
    {
        public int ID { get; set; }

        public int AccountReceivableID { get; set; }

        public decimal Amount { get; set; }

        public string CurrencyID { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsSynchronous { get; set; }
    }
}
