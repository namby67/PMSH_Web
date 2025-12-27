using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PromotionBO : BaseBO
    {
        private PromotionFacade facade = PromotionFacade.Instance;
        protected static PromotionBO instance = new PromotionBO();

        protected PromotionBO()
        {
            this.baseFacade = facade;
        }

        public static PromotionBO Instance
        {
            get { return instance; }
        }
    }
}
