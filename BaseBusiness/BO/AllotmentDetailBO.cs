using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class AllotmentDetailBO : BaseBO
    {
        private AllotmentDetailFacade facade = AllotmentDetailFacade.Instance;
        protected static AllotmentDetailBO instance = new AllotmentDetailBO();

        protected AllotmentDetailBO()
        {
            this.baseFacade = facade;
        }

        public static AllotmentDetailBO Instance
        {
            get { return instance; }
        }
    }
}
