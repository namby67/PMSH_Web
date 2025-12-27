using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class TelephoneSwitchModel
    {
        public int ID { get; set; }           
        public string RoomNo { get; set; }    
        public string GuestName { get; set; }  
        public int Status { get; set; }      
        public DateTime CreateDate { get; set; }
    }

}
