using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ReservationRateModel : BaseModel
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public int RateCodeID { get; set; }
        public DateTime RateDate { get; set; }
        public decimal Rate { get; set; }
        public bool FixedRate { get; set; }
        public string CurrencyID { get; set; }
        public int RoomID { get; set; }
        public string RoomNo { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomType { get; set; }
        public bool ChangeRateStatus { get; set; }
        public string TransactionCode { get; set; }
        public decimal RoomRevenueBeforeTax { get; set; }
        public decimal RoomRevenueAfterTax { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal RateAfterTax { get; set; }
        public bool IsTaxInclude { get; set; }
        public int NoOfAdult { get; set; }
        public int NoOfChild { get; set; }
        public int NoOfChild1 { get; set; }
        public int NoOfChild2 { get; set; }
        public int MarketID { get; set; }
        public int SourceID { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
        public int AllotmentID { get; set; }
        public string FixedRateByUser { get; set; }
        public int RTCID { get; set; }
        public string UpgradeBy { get; set; }
        public string UpgradeWhy { get; set; }
        public string DiscountReason { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }
        public bool FixedMeal { get; set; }
    }
}
