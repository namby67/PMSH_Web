using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PromotionFacade : BaseFacadeDB
    {
        protected static PromotionFacade instance = new PromotionFacade(new PromotionModel());
        protected PromotionFacade(PromotionModel model) : base(model)
        {
        }
        public static PromotionFacade Instance
        {
            get { return instance; }
        }
        protected PromotionFacade() : base()
        {
        }
    }
}
