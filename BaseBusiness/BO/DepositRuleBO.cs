using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class DepositRuleBO : BaseBO
    {
        private DepositRuleFacade facade = DepositRuleFacade.Instance;
        protected static DepositRuleBO instance = new DepositRuleBO();

        protected DepositRuleBO()
        {
            this.baseFacade = facade;
        }

        public static DepositRuleBO Instance
        {
            get { return instance; }
        }
    }
}
