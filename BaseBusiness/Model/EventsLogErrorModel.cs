using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class EventsLogErrorModel : BaseModel
    {
        public int ID { get; set; }
        public string MessageCode { get; set; }
        public string ComputerName { get; set; }
        public DateTime ErrorDate { get; set; }
        public string FormName { get; set; }
        public string EventName { get; set; }
        public string ErrorContent { get; set; }
    }
}
