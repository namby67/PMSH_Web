using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class DepositPaymentBO : BaseBO
    {
        private DepositPaymentFacade facade = DepositPaymentFacade.Instance;
        protected static DepositPaymentBO instance = new DepositPaymentBO();

        protected DepositPaymentBO()
        {
            this.baseFacade = facade;
        }

        public static DepositPaymentBO Instance
        {
            get { return instance; }
        }
    }
}
