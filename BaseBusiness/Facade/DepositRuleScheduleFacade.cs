using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class DepositRuleScheduleFacade : BaseFacadeDB
    {
        protected static DepositRuleScheduleFacade instance = new DepositRuleScheduleFacade(new DepositRuleScheduleModel());
        protected DepositRuleScheduleFacade(DepositRuleScheduleModel model) : base(model)
        {
        }
        public static DepositRuleScheduleFacade Instance
        {
            get { return instance; }
        }
        protected DepositRuleScheduleFacade() : base()
        {
        }
    }
}
