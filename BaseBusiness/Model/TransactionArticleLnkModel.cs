using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class TransactionArticleLnkModel : BaseModel
    {
        public int ID { get; set; }
        public string? TransactionCode { get; set; } = string.Empty;
        public string? ArticleCode { get; set; } = string.Empty;
    }
}
