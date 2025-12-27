using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationTracesModel : BaseModel
    {
        public int ID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string TracesTime { get; set; }
        public int DepartmentID { get; set; }
        public string TracesText { get; set; }
        public int Resolved { get; set; }
        public int ProfileID { get; set; }
        public int ReservationID { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserUpdateID { get; set; }
        public string ResolvedBy { get; set; }
        public DateTime ResolvedDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
