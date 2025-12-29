using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseBusiness.Facade
{
    public class RateCategoryFacade : BaseFacadeDB
    {
        protected static RateCategoryFacade instance = new RateCategoryFacade(new RateCategoryModel());
        protected RateCategoryFacade(RateCategoryModel model) : base(model)
        {
        }
        public static RateCategoryFacade Instance
        {
            get { return instance; }
        }
        protected RateCategoryFacade() : base()
        {
        }
    }
}
