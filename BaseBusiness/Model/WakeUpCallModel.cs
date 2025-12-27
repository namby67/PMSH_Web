using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class WakeUpCallModel : BaseModel
    {
    
        public int ID { get; set; }


        public string Name { get; set; }

        public int RoomID { get; set; }

        public DateTime WakeUpTime { get; set; }

        public int ShareRoom { get; set; }

        public int Status { get; set; }

        public int ProfileGroupID { get; set; }

        public int DialNo { get; set; }

        public int UserInsertID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public int UserUpdateID { get; set; }

        public int Action { get; set; }

       
        public string Remarks { get; set; }
    }
}
