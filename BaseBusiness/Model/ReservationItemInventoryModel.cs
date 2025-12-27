using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationItemInventoryModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public int ItemID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public string RateCode { get; set; }
        public int PackageID { get; set; }
        public string Package { get; set; }
        public int ReservationFixedChargeID { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
