using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class WakeUpCallLogBO : BaseBO
    {
        private WakeUpCallLogFacade facade = WakeUpCallLogFacade.Instance;
        protected static WakeUpCallLogBO instance = new WakeUpCallLogBO();

        protected WakeUpCallLogBO()
        {
            this.baseFacade = facade;
        }

        public static WakeUpCallLogBO Instance
        {
            get { return instance; }
        }
    }
}
