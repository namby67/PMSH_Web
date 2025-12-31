using System.ComponentModel.DataAnnotations;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class RoutingCodeModel : BaseModel
    {
        public int ID { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string TransactionCodes { get; set; } = string.Empty;

        // ===== OVERRIDE NGHIỆP VỤ =====

        // Vì PK là string
        public override string GetStringID()
        {
            return Code;
        }

        // Cho base biết PK là Code, không phải ID
        public override string GetPrimaryKeyName()
        {
            return "Code";
        }

        // (Optional) dùng cho sort / audit
        public override long GetID()
        {
            return ID;
        }
    }
}
