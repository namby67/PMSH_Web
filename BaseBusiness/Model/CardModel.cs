using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class CardModel : BaseModel
    {
        public string ID { get; set; }           // varchar(21), not null
        public int CardTypeID { get; set; }     // int, null
        public int Status { get; set; }         // int, null
        public DateTime CreatedDate { get; set; }   // datetime, null
        public string CreatedBy { get; set; }        // varchar(20), null
        public DateTime UpdatedDate { get; set; }   // datetime, null
        public string UpdatedBy { get; set; }        // varchar(20), null
        public bool CanSell { get; set; }        // bit, not null
    }
}
