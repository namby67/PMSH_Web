using BaseBusiness.bc;
using DevExpress.CodeParser;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static log4net.Appender.RollingFileAppender;

namespace BaseBusiness.Model
{
    public class ReservationTypeModel : BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Sequence { get; set; }
        public bool ArrivalTimeRequired { get; set; }
        public bool CreditCardRequired { get; set; }
        public bool Deduct { get; set; }
        public bool DepositRequired { get; set; }
        public bool Inactive { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserUpdateID { get; set; }
    }
}
