using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class hkpFacilityTaskBO : BaseBO
    {
        private hkpFacilityTaskFacade facade = hkpFacilityTaskFacade.Instance;
        protected static hkpFacilityTaskBO instance = new hkpFacilityTaskBO();

        protected hkpFacilityTaskBO()
        {
            this.baseFacade = facade;
        }

        public static hkpFacilityTaskBO Instance
        {
            get { return instance; }
        }
    }
}
