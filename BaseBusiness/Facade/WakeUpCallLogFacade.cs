using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class WakeUpCallLogFacade : BaseFacadeDB
    {
        protected static WakeUpCallLogFacade instance = new WakeUpCallLogFacade(new WakeUpCallLogModel());
        protected WakeUpCallLogFacade(WakeUpCallLogModel model) : base(model)
        {
        }
        public static WakeUpCallLogFacade Instance
        {
            get { return instance; }
        }
        protected WakeUpCallLogFacade() : base()
        {
        }
    }
}
