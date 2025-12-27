using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PaymentMethodBO : BaseBO
    {
        private PaymentMethodFacade facade = PaymentMethodFacade.Instance;
        protected static PaymentMethodBO instance = new PaymentMethodBO();

        protected PaymentMethodBO()
        {
            this.baseFacade = facade;
        }

        public static PaymentMethodBO Instance
        {
            get { return instance; }
        }
    }
}
