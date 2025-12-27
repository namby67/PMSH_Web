using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ApprovedbyFacade : BaseFacadeDB
    {
        protected static ApprovedbyFacade instance = new ApprovedbyFacade(new ApprovedbyModel());
        protected ApprovedbyFacade(ApprovedbyModel model) : base(model)
        {
        }
        public static ApprovedbyFacade Instance
        {
            get { return instance; }
        }
        protected ApprovedbyFacade() : base()
        {
        }
    }
}
