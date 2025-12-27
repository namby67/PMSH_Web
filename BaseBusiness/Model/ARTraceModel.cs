using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ARTraceModel : BaseModel
    {
        public int ID { get; set; }

        public int ARAccountID { get; set; }

        public string TraceText { get; set; }

        public DateTime TraceAt { get; set; }

        public DateTime ResolvedAt { get; set; }

        public string ResolvedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }
    }
}
