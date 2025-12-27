using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class WakeUpCallFacade : BaseFacadeDB
    {
        protected static WakeUpCallFacade instance = new WakeUpCallFacade(new WakeUpCallModel());
        protected WakeUpCallFacade(WakeUpCallModel model) : base(model)
        {
        }
        public static WakeUpCallFacade Instance
        {
            get { return instance; }
        }
        protected WakeUpCallFacade() : base()
        {
        }
    }
}
