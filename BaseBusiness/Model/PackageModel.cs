using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class PackageModel : BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int ForecastGroupID { get; set; }
        public string PackageList { get; set; }
        public bool TaxInclusive { get; set; }
        public string TransCodeAlt { get; set; }
        public string ArticlesCodeAlt { get; set; }
        public int Allowance { get; set; }
        public string TrnCodeProfit { get; set; }
        public string TrnCodeLoss { get; set; }
        public bool IncludedInRate { get; set; }
        public bool RateSeparateLine { get; set; }
        public bool RateCombineLine { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Safari { get; set; }
        public bool Active { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }
        public bool VAP { get; set; }

    }
}
