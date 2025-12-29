using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class AllotmentStageFacade : BaseFacadeDB
    {
        protected static AllotmentStageFacade instance = new AllotmentStageFacade(new AllotmentStageModel());
        protected AllotmentStageFacade(AllotmentStageModel model) : base(model)
        {
        }
        public static AllotmentStageFacade Instance
        {
            get { return instance; }
        }
        protected AllotmentStageFacade() : base()
        {
        }
    }
}
