using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class AllotmentTypeBO : BaseBO
    {
        private AllotmentTypeFacade facade = AllotmentTypeFacade.Instance;
        protected static AllotmentTypeBO instance = new AllotmentTypeBO();

        protected AllotmentTypeBO()
        {
            this.baseFacade = facade;
        }

        public static AllotmentTypeBO Instance
        {
            get { return instance; }
        }
    }
}
