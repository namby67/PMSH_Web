using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Dto
{
    public class DataBillingRecord
    {
        public int id { get; set; }
        public string date { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string invoiceNo { get; set; }
        public string amount { get; set; } // String to match frontend; parse to decimal if needed
        public string supplement { get; set; }
        public string reference { get; set; }
        public string userName { get; set; }
        public string time { get; set; }
        public string groupCode { get; set; }
        public string subgroupCode { get; set; }
        public string shiftID { get; set; }
        public string property { get; set; }
        public string transactionNo { get; set; }
    }
}
