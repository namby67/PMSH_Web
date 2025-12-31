using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class CancellationRuleBO : BaseBO
    {
        private CancellationRuleFacade facade = CancellationRuleFacade.Instance;
        protected static CancellationRuleBO instance = new CancellationRuleBO();

        protected CancellationRuleBO()
        {
            this.baseFacade = facade;
        }

        public static CancellationRuleBO Instance
        {
            get { return instance; }
        }
    }
}
