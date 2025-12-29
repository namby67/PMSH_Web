using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ConfigSystemModel : BaseModel
    {
        public int ID { get;set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public string Desciption { get; set; }
        public int UserInsertID { get; set;}
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
        public string KeyValue1 { get; set; }
        public string KeyValue2 { get; set; }

        public string KeyValue3 { get; set; }

    }
}
