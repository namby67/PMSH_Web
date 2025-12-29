using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class hkpFacilityTaskModel : BaseModel
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string Instructions { get; set; }

        public int Sequence { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Inactive { get; set; }
    }
}
