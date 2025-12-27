using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Dto
{
    public class ItemPost
    {
        public string transCode { get; set; }
        public string transName { get; set; }
        public string articleCode { get; set; }
        public string articleName { get; set; }
        public string quantity { get; set; }
        public string priceNet { get; set; }
        public string price { get; set; }
        public string amount { get; set; }
        public string amountNet { get; set; }
    }
}
