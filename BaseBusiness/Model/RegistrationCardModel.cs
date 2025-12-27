using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class RegistrationCardModel : BaseModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int BrandID { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get;set; }
    }
}
