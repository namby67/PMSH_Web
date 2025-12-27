using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ActivityLogFacade : BaseFacadeDB
    {
        protected static ActivityLogFacade instance = new ActivityLogFacade(new ActivityLogModel());
        protected ActivityLogFacade(ActivityLogModel model) : base(model)
        {
        }
        public static ActivityLogFacade Instance
        {
            get { return instance; }
        }
        protected ActivityLogFacade() : base()
        {
        }
    }
}
