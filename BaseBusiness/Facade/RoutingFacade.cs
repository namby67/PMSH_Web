using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class RoutingFacade : BaseFacadeDB
    {
        protected static RoutingFacade instance = new RoutingFacade(new RoutingModel());
        protected RoutingFacade(RoutingModel model) : base(model)
        {
        }
        public static RoutingFacade Instance
        {
            get { return instance; }
        }
        protected RoutingFacade() : base()
        {
        }
    }
}
