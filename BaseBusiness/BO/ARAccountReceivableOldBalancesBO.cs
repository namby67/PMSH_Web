using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ARAccountReceivableOldBalancesBO : BaseBO
    {
        private ARAccountReceivableOldBalancesFacade facade = ARAccountReceivableOldBalancesFacade.Instance;
        protected static ARAccountReceivableOldBalancesBO instance = new ARAccountReceivableOldBalancesBO();

        protected ARAccountReceivableOldBalancesBO()
        {
            this.baseFacade = facade;
        }

        public static ARAccountReceivableOldBalancesBO Instance
        {
            get { return instance; }
        }
    }
}
