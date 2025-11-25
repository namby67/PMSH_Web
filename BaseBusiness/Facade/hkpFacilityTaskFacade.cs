using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpFacilityTaskFacade : BaseFacadeDB
    {
        protected static hkpFacilityTaskFacade instance = new hkpFacilityTaskFacade(new hkpFacilityTaskModel());
        protected hkpFacilityTaskFacade(hkpFacilityTaskModel model) : base(model)
        {
        }
        public static hkpFacilityTaskFacade Instance
        {
            get { return instance; }
        }
        protected hkpFacilityTaskFacade() : base()
        {
        }
    }
}
