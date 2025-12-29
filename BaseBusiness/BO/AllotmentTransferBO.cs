using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class AllotmentTransferBO : BaseBO
    {
        private AllotmentTransferFacade facade = AllotmentTransferFacade.Instance;
        protected static AllotmentTransferBO instance = new AllotmentTransferBO();

        protected AllotmentTransferBO()
        {
            this.baseFacade = facade;
        }

        public static AllotmentTransferBO Instance
        {
            get { return instance; }
        }
    }
}
