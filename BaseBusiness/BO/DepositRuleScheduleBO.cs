using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class DepositRuleScheduleBO : BaseBO
    {
        private DepositRuleScheduleFacade facade = DepositRuleScheduleFacade.Instance;
        protected static DepositRuleScheduleBO instance = new DepositRuleScheduleBO();

        protected DepositRuleScheduleBO()
        {
            this.baseFacade = facade;
        }

        public static DepositRuleScheduleBO Instance
        {
            get { return instance; }
        }
    }
}
