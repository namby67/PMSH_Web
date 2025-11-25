using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ARPaymentFacade : BaseFacadeDB
    {
        protected static ARPaymentFacade instance = new ARPaymentFacade(new ARPaymentModel());
        protected ARPaymentFacade(ARPaymentModel model) : base(model)
        {
        }
        public static ARPaymentFacade Instance
        {
            get { return instance; }
        }
        protected ARPaymentFacade() : base()
        {
        }
    }
}
