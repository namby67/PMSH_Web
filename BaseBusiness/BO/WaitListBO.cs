using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class WaitListBO : BaseBO
    {
        private WaitListFacade facade = WaitListFacade.Instance;
        protected static WaitListBO instance = new WaitListBO();

        protected WaitListBO()
        {
            this.baseFacade = facade;
        }

        public static WaitListBO Instance
        {
            get { return instance; }
        }
    }
}
