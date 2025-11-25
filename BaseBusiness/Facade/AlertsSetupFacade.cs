using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class AlertsSetupFacade : BaseFacadeDB
    {
        protected static AlertsSetupFacade instance = new AlertsSetupFacade(new AlertsSetupModel());
        protected AlertsSetupFacade(AlertsSetupModel model) : base(model)
        {
        }
        public static AlertsSetupFacade Instance
        {
            get { return instance; }
        }
        protected AlertsSetupFacade() : base()
        {
        }
    }
}
