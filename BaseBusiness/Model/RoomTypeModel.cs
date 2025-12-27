using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class RoomTypeModel : BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplaySequence { get; set; }
        public int RoomClassID { get; set; }
        public string RoomClassCode { get; set; }
        public int MaxOccupancy { get; set; }
        public int MaxRollAway { get; set; }
        public string RateCode { get; set; }
        public decimal RateAmount { get; set; }
        public int DefOccupancy { get; set; }
        public DateTime ActiveDate { get; set; }
        public bool IsPseudo { get; set; }
        public bool GenericFlag { get; set; }
        public bool IsMeetingRoom { get; set; }
        public int ZoneID { get; set; }
        public string ZoneCode { get; set; }
        public string Image { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserUpdateID { get; set; }
        public int InActive { get; set; }
        public bool IsWeb { get; set; }
        public string Pic { get; set; }
    }
}
