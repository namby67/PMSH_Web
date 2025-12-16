using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class OccupancyModel : BaseModel
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public int RoomTypeID { get; set; }
        public decimal? Occupancylevel { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
