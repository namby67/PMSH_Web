using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ArticleModel : BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string TransactionCode { get; set; }
        public decimal DefaultPrice { get; set; }
        public string CurrencyID { get; set; }
        public bool IsActive { get; set; }
        public int UnitID { get; set; }
        public int ConversionUnitID { get; set; }
        public decimal Exchange { get; set; }
        public int ArticleType { get; set; }
        public string Supplement { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserUpdateID { get; set; }
        public int UserInsertID { get; set; }
        public bool IsMiniBar { get; set; }
        public bool IsTransfer { get; set; }
    }
}
