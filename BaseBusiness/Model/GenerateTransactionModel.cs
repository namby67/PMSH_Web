using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class GenerateTransactionModel : BaseModel
    {
        public int ID { get; set; }
        public int GenerateGroupID { get; set; }
        public int TransactionGroupID { get; set; }
        public int TransactionSubGroupID { get; set; }
        public string GroupCode { get; set; }
        public string SubgroupCode {get; set; }
        public int GroupType { get; set; }
        public int Type { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionCodeDetail { get; set; }
        public string Description { get; set; }
        public decimal Percentage { get; set; }
        public decimal Amount { get; set; }
        public string UDFFunction { get; set; }
        public int BaseAmount { get; set; }
        public bool Subtotal1 { get; set; }
        public bool Subtotal2 { get; set; }
        public bool Subtotal3 { get; set; }

    }
}
