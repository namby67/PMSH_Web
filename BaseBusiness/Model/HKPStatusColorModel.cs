using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class HKPStatusColorModel : BaseModel
    {
        public int ID { get; set; }
        public string ColorName { get; set; }
        public string StatusName { get; set; }
        public string FontColorName { get; set; }
        public string Description { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
