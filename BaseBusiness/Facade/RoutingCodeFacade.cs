using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class RoutingCodeFacade : BaseFacadeDB
    {
        protected static readonly RoutingCodeFacade instance = new(new RoutingCodeModel());
        protected RoutingCodeFacade(RoutingCodeModel model) : base(model)
        {
        }
        public static RoutingCodeFacade Instance
        {
            get { return instance; }
        }
    }
}
