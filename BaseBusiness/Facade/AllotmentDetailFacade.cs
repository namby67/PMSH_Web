using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class AllotmentDetailFacade :  BaseFacadeDB
    {
        protected static AllotmentDetailFacade instance = new AllotmentDetailFacade(new AllotmentDetailModel());
        protected AllotmentDetailFacade(AllotmentDetailModel model) : base(model)
        {
        }
        public static AllotmentDetailFacade Instance
        {
            get { return instance; }
        }
        protected AllotmentDetailFacade() : base()
        {
        }
    }
}
