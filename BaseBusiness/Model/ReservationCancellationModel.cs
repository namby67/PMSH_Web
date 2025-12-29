using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationCancellationModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public DateTime CancellationDate { get;set; }
        public string CancellationNo { get; set; }
        public string ReasonCancellation { get; set; }
        public string Description { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get;set;}
    }
}
