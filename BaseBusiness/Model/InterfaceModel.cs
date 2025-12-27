using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class InterfaceModel : BaseModel
    {
        public int ID { get; set; }
        public string KeyValue { get; set; }
        public string Description { get;set; }
        public DateTime CreateDate { get; set; }
    }
}
