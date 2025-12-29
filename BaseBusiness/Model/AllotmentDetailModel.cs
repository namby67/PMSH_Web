using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class AllotmentDetailModel : BaseModel
    {
        public int ID { get; set; }
        public int AllotmentID { get; set; }
        public DateTime AllotmentDate { get; set; }
        public int RoomTypeID { get; set; }
        public int Quantity { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CutOffDate { get; set; }
        public int CutOffDay { get; set; }
        public int AllotmentStageID { get; set; }
    }
}
