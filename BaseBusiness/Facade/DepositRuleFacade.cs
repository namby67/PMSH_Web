using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class DepositRuleFacade : BaseFacadeDB
    {
        protected static DepositRuleFacade instance = new DepositRuleFacade(new DepositRuleModel());
        protected DepositRuleFacade(DepositRuleModel model) : base(model)
        {
        }
        public static DepositRuleFacade Instance
        {
            get { return instance; }
        }
        protected DepositRuleFacade() : base()
        {
        }
    }
}
