
using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class RateCategoryBO : BaseBO
    {
        private readonly RateCategoryFacade facade = RateCategoryFacade.Instance;
        private readonly static RateCategoryBO instance = new();

        protected RateCategoryBO()
        {
            this.baseFacade = facade;
        }

        public static RateCategoryBO Instance
        {
            get { return instance; }
        }
    }
}
