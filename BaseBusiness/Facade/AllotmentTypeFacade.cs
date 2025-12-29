using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class AllotmentTypeFacade : BaseFacadeDB
    {
        protected static AllotmentTypeFacade instance = new AllotmentTypeFacade(new AllotmentTypeModel());
        protected AllotmentTypeFacade(AllotmentTypeModel model) : base(model)
        {
        }
        public static AllotmentTypeFacade Instance
        {
            get { return instance; }
        }
        protected AllotmentTypeFacade() : base()
        {
        }
    }
}
