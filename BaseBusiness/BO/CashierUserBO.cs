using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class CashierUserBO : BaseBO
    {
        private CashierUserFacade facade = CashierUserFacade.Instance;
        protected static CashierUserBO instance = new CashierUserBO();

        protected CashierUserBO()
        {
            this.baseFacade = facade;
        }

        public static CashierUserBO Instance
        {
            get { return instance; }
        }
    }
}
