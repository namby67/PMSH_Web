using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class RoomOwnerProfileModel : BaseModel
    {
        public int ID { get; set; }
        public string OwnerCode { get; set; }
        public string OwnerName { get; set; }
        public string RoomNo { get; set; }
        public int RoomID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
