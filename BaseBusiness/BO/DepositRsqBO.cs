using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class DepositRsqBO : BaseBO
    {
        private DepositRsqFacade facade = DepositRsqFacade.Instance;
        protected static DepositRsqBO instance = new DepositRsqBO();

        protected DepositRsqBO()
        {
            this.baseFacade = facade;
        }

        public static DepositRsqBO Instance
        {
            get { return instance; }
        }
    }
}
