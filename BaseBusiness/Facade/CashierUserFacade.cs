using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class CashierUserFacade : BaseFacadeDB
    {
        protected static CashierUserFacade instance = new CashierUserFacade(new CashierUserModel());
        protected CashierUserFacade(CashierUserModel model) : base(model)
        {
        }
        public static CashierUserFacade Instance
        {
            get { return instance; }
        }
        protected CashierUserFacade() : base()
        {
        }
    }
}
