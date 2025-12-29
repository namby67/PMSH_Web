using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ProfileMemberCardModel : BaseModel
    {
        public int ID { get; set; }
        public int ProfileID { get; set; }
        public string MemberNo { get; set; }
        public int MemberTypeID { get; set; }
        public string MemberLevel { get; set; }
        public string Description { get; set; }
        public DateTime Expiry { get; set; }
        public int Status { get; set; }
        public bool InActive { get; set; }
        public bool IsDeleted { get; set; }
        public int Sequence { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
