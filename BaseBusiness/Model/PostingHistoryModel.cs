using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class PostingHistoryModel : BaseModel
    {
        public int ID { get; set; }
        public int ActionType { get; set; }
        public string ActionText { get; set; }
        public DateTime ActionDate { get; set; }
        public string ActionUser { get; set; }
        public string InvoiceNo { get; set; }
        public decimal Amount { get; set; }
        public string Supplement { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate{ get; set; }
        public string ReasonCode { get; set; }
        public string ReasonText { get;set; }
        public string Terminal { get; set; }
        public string Machine { get; set; }
        public int Action_FolioID { get; set; }
        public int AfterAction_FolioID { get; set; }
        public string Property { get; set; }
    }
}
