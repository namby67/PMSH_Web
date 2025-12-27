using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PaymentMethodFacade : BaseFacadeDB
    {
        protected static PaymentMethodFacade instance = new PaymentMethodFacade(new PaymentMethodModel());
        protected PaymentMethodFacade(PaymentMethodModel model) : base(model)
        {
        }
        public static PaymentMethodFacade Instance
        {
            get { return instance; }
        }
        protected PaymentMethodFacade() : base()
        {
        }
    }
}
