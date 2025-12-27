using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class CashierUserModel : BaseModel
    {
        public int ID { get; set; } // PRIMARY KEY

        public int UserID { get; set; }

        public string CashierNo { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public bool Status { get; set; }

        public int UserInsertID { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserUpdateID { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
