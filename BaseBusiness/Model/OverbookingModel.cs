using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class OverbookingModel : BaseModel
    {
        public int ID { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomType { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get;set; }
        public int OverbookLevel { get; set; }
        public int Type { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
