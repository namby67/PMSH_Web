using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class DepositPaymentFacade : BaseFacadeDB
    {
        protected static DepositPaymentFacade instance = new DepositPaymentFacade(new DepositPaymentModel());
        protected DepositPaymentFacade(DepositPaymentModel model) : base(model)
        {
        }
        public static DepositPaymentFacade Instance
        {
            get { return instance; }
        }
        protected DepositPaymentFacade() : base()
        {
        }
    }
}
