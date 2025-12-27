using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class InventoryUpdateRequest
    {
        public int ItemID { get; set; }
        public DateTime MatchDate { get; set; } // Dùng để tìm ID (Begin Date)
        public DateTime Date { get; set; } // End Date
        public int Quantity { get; set; }
        public int UserID { get; set; }
    }

}
