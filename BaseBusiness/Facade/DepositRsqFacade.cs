using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class DepositRsqFacade : BaseFacadeDB
    {
        protected static DepositRsqFacade instance = new DepositRsqFacade(new DepositRsqModel());
        protected DepositRsqFacade(DepositRsqModel model) : base(model)
        {
        }
        public static DepositRsqFacade Instance
        {
            get { return instance; }
        }
        protected DepositRsqFacade() : base()
        {
        }
    }
}
