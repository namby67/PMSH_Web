using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ActivityLogModel : BaseModel
    {
        public int ID { get; set; }
        public string TableName { get; set; }
        public int ObjectID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Change { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Description { get; set; }
    }
}
