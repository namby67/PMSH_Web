using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class PackageDetailModel : BaseModel
    {
        public int ID { get; set; }

        public int PackageID { get; set; }
        public int? SeasonID { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string? TransCode { get; set; }
        public string? ArticlesCode { get; set; }
        public string? TransCodeOver { get; set; }
        public string? ArticlesCodeOver { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; } = 0;
        public string? CurrencyID { get; set; } 

        public decimal? AllowanceAmount { get; set; } = 0;

        public int RhythmPostingID { get; set; } 
        public int? CalculationRuleID { get; set; } = 0 ;

        public DateTime? PostingDate { get; set; }
        public string? PostingDay { get; set; }

        public decimal? PriceAfterTax { get; set; } = 0;
        public bool? IsTaxInclude { get; set; }

        public int UserInsertID { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? UserUpdateID { get; set; }
        public DateTime? UpdateDate { get; set; }

    }

}
