using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ItemModel : BaseModel
    {
        public int ID {  get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TransactionCode { get;set; }
        public string ArticleCode { get; set; }
        public string Cost { get; set; }
        public int RateCodeID { get; set; }
        public decimal RateAmount { get; set; }
        public int ItemGroupID { get; set; }
        public int DepartmentID { get; set; }
        public int QuantityStock { get; set; }
        public int QuantityDefault { get; set; }
        public string SetupTime { get; set; }
        public string SetDownTime { get; set; }
        public string AvailableFrom { get; set; }
        public string AvailableTo { get; set; }
        public string Traces { get; set; }
        public string Attribute { get;set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
    }
}
