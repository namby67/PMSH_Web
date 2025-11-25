using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationAlertsModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public string Code { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
        public int OriginAlertID { get; set; }
        public int WarningDay { get; set; }
        public int IsActive { get; set; }
    }
}
