using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class RoutingModel : BaseModel
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public int FromReservationID { get; set; }
        public int ToReservationID { get; set; }
        public int ToFolioNo { get; set; }
        public int ToRoomID { get; set; }
        public int ProfileID { get; set; }
        public string AccountName { get; set; }
        public string TransactionCodes { get; set; }
        public decimal Limit { get; set; }
        public decimal Percents { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool EntireDate { get; set; }
        public bool IsDefault { get; set; }
        public bool IsMasterFolio { get; set; }
        public string ConfirmationNo { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserUpdateID { get; set; }
    }
}
