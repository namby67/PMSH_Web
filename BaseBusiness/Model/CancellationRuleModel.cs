using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class CancellationRuleModel : BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public decimal AmountValue { get; set; }
        public string CurrencyID { get; set; }
        public int DaysBeforeArrival { get; set; }
        public DateTime CancelBeforeTime { get; set; }
        public int Sequence { get; set; }
        public bool Inactive { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
