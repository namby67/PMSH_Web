using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class lafLostAndFoundModel : BaseModel
    {
   
        public int ID { get; set; }
        public int StatusID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public int ZoneID { get; set; }
        public string Location { get; set; }
        public string Finder { get; set; }
        public string SurrenderBy { get; set; }
        public string SignatureName { get; set; }
        public string PlaceStore { get; set; }
        public DateTime SendDate { get; set; }   
        public string SendName { get; set; }
        public int QualityTypeID { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
