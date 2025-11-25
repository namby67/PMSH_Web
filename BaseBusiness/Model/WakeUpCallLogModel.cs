using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class WakeUpCallLogModel : BaseModel
    {
        public int ID { get; set; }

        public int WakeUpCallID { get; set; }

        public string ActionDescription { get; set; }

        public DateTime CreateDate { get; set; }

        public string RoomNo { get; set; }

        public string GuestName { get; set; }

        public string GroupName { get; set; }

        public string InsertDate { get; set; }

        public string InsertTime { get; set; }

        public string UserName { get; set; }
    }
}
