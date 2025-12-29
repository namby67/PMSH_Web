using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BaseBusiness.Model
{
    public class ShiftModel :  BaseModel
    {
        public int ID { get;set; }
		public DateTime LoginTime { get; set; }
        public DateTime  LogoutTime { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public bool Status { get; set; }
        public int ComputerID { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
