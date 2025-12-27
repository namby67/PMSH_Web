using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class AllotmentFacade : BaseFacadeDB
    {
        protected static AllotmentFacade instance = new AllotmentFacade(new AllotmentModel());
        protected AllotmentFacade(AllotmentModel model) : base(model)
        {
        }
        public static AllotmentFacade Instance
        {
            get { return instance; }
        }
        protected AllotmentFacade() : base()
        {
        }
    }
}
