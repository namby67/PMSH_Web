using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class RateClassBO : BaseBO
    {
        private RateClassFacade facade = RateClassFacade.Instance;
        protected static RateClassBO instance = new RateClassBO();

        protected RateClassBO()
        {
            this.baseFacade = facade;
        }

        public static RateClassBO Instance
        {
            get { return instance; }
        }
    }
}
