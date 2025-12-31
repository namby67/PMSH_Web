using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class GroupOwnerModel : BaseModel
    {
        public int ID { get; set; }
        public string GroupOwnerCode { get; set; }
        public string GroupOwnerName { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
