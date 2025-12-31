using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class CancellationRuleFacade : BaseFacadeDB
    {
        protected static CancellationRuleFacade instance = new CancellationRuleFacade(new CancellationRuleModel());
        protected CancellationRuleFacade(CancellationRuleModel model) : base(model)
        {
        }
        public static CancellationRuleFacade Instance
        {
            get { return instance; }
        }
        protected CancellationRuleFacade() : base()
        {
        }
    }
}
