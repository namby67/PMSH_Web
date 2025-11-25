using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
namespace BaseBusiness.Model
{
    public class BusinessDateModel : BaseModel
    {
        public int ID { get; set; }
        public DateTime BusinessDate { get; set; }
        public int ChangeStatus { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserUpdateID {get;set; }

        public static explicit operator BusinessDateModel(ArrayList v)
        {
            throw new NotImplementedException();
        }
    }
}
