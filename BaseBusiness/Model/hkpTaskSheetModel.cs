using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class hkpTaskSheetModel : BaseModel
    {
        public int ID { get; set; }

        public int TaskSheetNo { get; set; }

        public DateTime TaskSheetDate { get; set; }

        public string EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public int AttendantID { get; set; }

        public string TaskSheetNote { get; set; }

        public bool Status { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public string FacilityTaskID { get; set; }

        public string FacilityTask { get; set; }

        public string FacilityInstructions { get; set; }

        public string SessionID { get; set; }

        public string SessionName { get; set; }
    }
}
