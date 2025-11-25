using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class RateCodeModel : BaseModel
    {
        public int ID { get; set; }
        public string RateCode { get; set; }
        public int RateCategoryID { get; set; }
        public int RateClassID { get; set; }
        public string Descripton { get; set; } 
        public int Sequence { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public bool DayUse { get; set; }
        public byte DefaultDisplay { get; set; }
        public bool Negotiated { get; set; }
        public bool IsModify { get; set; }
        public bool IndividualOnly { get; set; }
    }
}
