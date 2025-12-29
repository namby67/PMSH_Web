using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class TelephoneSwitchUpdateModel
    {
        public string RoomNo { get; set; }       // số phòng
        public string GuestName { get; set; }    // tên khách
        public string OldValue { get; set; }     // trạng thái cũ (On/Off)
        public string NewValue { get; set; }     // trạng thái mới (On/Off)
    }
}
