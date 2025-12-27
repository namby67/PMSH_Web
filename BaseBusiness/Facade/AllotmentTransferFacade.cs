using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class AllotmentTransferFacade : BaseFacadeDB
    {
        protected static AllotmentTransferFacade instance = new AllotmentTransferFacade(new AllotmentTransferModel());
        protected AllotmentTransferFacade(AllotmentTransferModel model) : base(model)
        {
        }
        public static AllotmentTransferFacade Instance
        {
            get { return instance; }
        }
        protected AllotmentTransferFacade() : base()
        {
        }
    }
}
