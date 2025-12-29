using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class RoutingCodeBO : BaseBO
    {
        private readonly RoutingCodeFacade facade = RoutingCodeFacade.Instance;
        private static readonly RoutingCodeBO instance = new();

        protected RoutingCodeBO()
        {
            baseFacade = facade;
        }

        public static RoutingCodeBO Instance
        {
            get { return instance; }
        }
    }
}
