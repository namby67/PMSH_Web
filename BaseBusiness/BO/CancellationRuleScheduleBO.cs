using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class CancellationRuleScheduleBO : BaseBO
    {
        private CancellationRuleScheduleFacade facade = CancellationRuleScheduleFacade.Instance;
        protected static CancellationRuleScheduleBO instance = new CancellationRuleScheduleBO();

        protected CancellationRuleScheduleBO()
        {
            this.baseFacade = facade;
        }

        public static CancellationRuleScheduleBO Instance
        {
            get { return instance; }
        }
    }
}
