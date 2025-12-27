using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace BaseBusiness.Model
{
    public class RoomUpdateDTO
    {
        public string RoomNo { get; set; }  // chỉ 1 phòng
        public int NewHKFOStatus { get; set; }
    }


}
