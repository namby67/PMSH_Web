using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class RoomStatusHistoryModel : BaseModel
    {
        public int ID { get; set; }
        public int ObjectID { get; set; }
        public string TableName { get; set; }
        public string UserName { get; set; }
        public DateTime ChangeDate { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Action { get; set; }
        public string RoomNo { get; set; }
        public string ComputerName { get; set; }
    }
}
