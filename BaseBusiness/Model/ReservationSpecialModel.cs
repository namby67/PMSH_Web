using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationSpecialModel : BaseModel
    {
        public int ID { get; set; }

        public int ReservationID { get; set; }
        public int PreferenceID { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }
    }
}
