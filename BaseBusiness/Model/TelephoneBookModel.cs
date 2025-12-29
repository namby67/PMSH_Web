using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class TelephoneBookModel : BaseModel
    {  
        public int ID { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; }
        public string Address { get; set; }

        public string WebAddress { get; set; }

        public string Remark { get; set; }

        public int TelephoneBookCategoryID { get; set; }

        public int UserInsertID { get; set; }

        public int Color { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserUpdateID { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
