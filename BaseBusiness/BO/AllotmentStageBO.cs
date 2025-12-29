using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class AllotmentStageBO :  BaseBO
    {
        private AllotmentStageFacade facade = AllotmentStageFacade.Instance;
        protected static AllotmentStageBO instance = new AllotmentStageBO();

        protected AllotmentStageBO()
        {
            this.baseFacade = facade;
        }

        public static AllotmentStageBO Instance
        {
            get { return instance; }
        }
    }
}
