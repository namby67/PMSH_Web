using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class hkpTaskSheetDetailModel : BaseModel
    {
        public int ID { get; set; }
        public int TaskSheetID { get; set; }
        public string RoomNo { get; set; }
        public string RoomType { get; set; }
        public int HKStatusID { get; set; }
        public int FOStatus { get; set; }
        public decimal Credit { get; set; }
        public string FacilityTaskID { get; set; }
        public string FacilityTask { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string TaskNote { get; set; }
        public int Status { get; set; }
        public bool IsCompleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CompletedStatus { get; set; }
    }
}
