using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class PickupDropPlaceModel : BaseModel
    {
        public int ID { get; set; }

        public string Code { get; set; }  // nvarchar(20)

        public string Name { get; set; }  // nvarchar(100)

        public string Description { get; set; }  // nvarchar(150)

        public int CountryID { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserInsertID { get; set; }

        public DateTime UpdateDate { get; set; }

        public int UserUpdateID { get; set; }

        public bool Inactive { get; set; }

        public string CreatedBy { get; set; } // nvarchar(50)

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; } // nvarchar(50)

        public DateTime UpdatedDate { get; set; }
    }
}
