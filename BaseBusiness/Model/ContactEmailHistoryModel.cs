using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ContactEmailHistoryModel : BaseModel
    {
        public int ID { get; set; }
        public int GroupID { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int ContactRelateID { get; set; }
        public int SendBy { get; set; }
        public DateTime SendDate { get; set; }
        public int SendOK { get; set; }
        public string SendTo { get; set; }
        public string Reason { get; set; }
        public DateTime SuccessSendDate { get; set; }
        public int ContactEmailTemplateID { get; set; }
    }
}
