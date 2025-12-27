using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ARPaymentBO : BaseBO
    {
        private ARPaymentFacade facade = ARPaymentFacade.Instance;
        protected static ARPaymentBO instance = new ARPaymentBO();

        protected ARPaymentBO()
        {
            this.baseFacade = facade;
        }

        public static ARPaymentBO Instance
        {
            get { return instance; }
        }
    }
}
