using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class RateCodeDetailModel : BaseModel
    {
        public int ID { get; set; }

        public int? RateCodeID { get; set; }
        public int? RoomTypeID { get; set; }
        public int? RoomDirectionID { get; set; }
        public DateTime? RateDate { get; set; }
        public int? PackageID { get; set; }
        public int? PromotionID { get; set; }

        public decimal? Quantity { get; set; }
        public int? MinLOS { get; set; }
        public int? MaxLOS { get; set; }
        public int? AdvanceBooking { get; set; }
        public int? Allotment { get; set; }

        public DateTime? MinLeadTime { get; set; }
        public DateTime? MaxLeadTime { get; set; }

        public int? SeasonID { get; set; }

        public decimal? A1 { get; set; }
        public decimal? A2 { get; set; }
        public decimal? A3 { get; set; }
        public decimal? A4 { get; set; }
        public decimal? A5 { get; set; }
        public decimal? A6 { get; set; }

        public decimal? C1 { get; set; }
        public decimal? C2 { get; set; }
        public decimal? C3 { get; set; }

        public int? MinNoOfRoom { get; set; }
        public int? MaxNoOfRoom { get; set; }

        public string? TransactionCode { get; set; }
        public string? CurrencyID { get; set; }

        public int? FormulaDetailID { get; set; }
        public int? Status { get; set; }

        public bool? PrintRate { get; set; }
        public bool? Discount { get; set; }

        // ===== After Tax (NOT NULL, default 0) =====
        public decimal A1AfterTax { get; set; }
        public decimal A2AfterTax { get; set; }
        public decimal A3AfterTax { get; set; }
        public decimal A4AfterTax { get; set; }
        public decimal A5AfterTax { get; set; }
        public decimal A6AfterTax { get; set; }

        public decimal C1AfterTax { get; set; }
        public decimal C2AfterTax { get; set; }
        public decimal C3AfterTax { get; set; }

        public int DepositRuleID { get; set; }
        public int DepositCancellationRuleID { get; set; }
        public int ReservationTypeID { get; set; }

        public bool IsActiveDepositRule { get; set; }
        public bool IsActiveCancelRule { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public bool IsTaxInclude { get; set; }

        // ===== A7 → A15 =====
        public decimal? A7 { get; set; }
        public decimal? A8 { get; set; }
        public decimal? A9 { get; set; }
        public decimal? A10 { get; set; }
        public decimal? A11 { get; set; }
        public decimal? A12 { get; set; }
        public decimal? A13 { get; set; }
        public decimal? A14 { get; set; }
        public decimal? A15 { get; set; }

        public decimal? A7AfterTax { get; set; }
        public decimal? A8AfterTax { get; set; }
        public decimal? A9AfterTax { get; set; }
        public decimal? A10AfterTax { get; set; }
        public decimal? A11AfterTax { get; set; }
        public decimal? A12AfterTax { get; set; }
        public decimal? A13AfterTax { get; set; }
        public decimal? A14AfterTax { get; set; }
        public decimal? A15AfterTax { get; set; }

        public decimal? AdultExtra { get; set; }
        public decimal? AdultExtraTax { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public int? UserInsertID { get; set; }
        public int? UserUpdateID { get; set; }
    }

}
