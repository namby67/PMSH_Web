using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class CancellationRuleScheduleFacade : BaseFacadeDB
    {
        protected static CancellationRuleScheduleFacade instance = new CancellationRuleScheduleFacade(new CancellationRuleScheduleModel());
        protected CancellationRuleScheduleFacade(CancellationRuleScheduleModel model) : base(model)
        {
        }
        public static CancellationRuleScheduleFacade Instance
        {
            get { return instance; }
        }
        protected CancellationRuleScheduleFacade() : base()
        {
        }
    }
}
