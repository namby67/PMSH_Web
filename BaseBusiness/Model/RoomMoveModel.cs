using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class RoomMoveModel : BaseModel
    {
        public int ID { get; set;}
        public int ReservationID { get; set; }
        public int FromRoomID { get; set; }
        public int ToRoomID { get; set; }
        public int FromStatus { get; set;}
        public int ToStatus { get; set;}
        public DateTime MoveDate { get; set; }
        public string Reason { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
