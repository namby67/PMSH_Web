using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class RoutingBO : BaseBO
    {
        private RoutingFacade facade = RoutingFacade.Instance;
        protected static RoutingBO instance = new RoutingBO();

        protected RoutingBO()
        {
            this.baseFacade = facade;
        }

        public static RoutingBO Instance
        {
            get { return instance; }
        }
    }
}
