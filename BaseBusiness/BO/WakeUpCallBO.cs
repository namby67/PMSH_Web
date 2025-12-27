using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class WakeUpCallBO : BaseBO
    {
        private WakeUpCallFacade facade = WakeUpCallFacade.Instance;
        protected static WakeUpCallBO instance = new WakeUpCallBO();

        protected WakeUpCallBO()
        {
            this.baseFacade = facade;
        }

        public static WakeUpCallBO Instance
        {
            get { return instance; }
        }
    }
}
