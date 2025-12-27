using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class hkpTaskSheetFacilityBO : BaseBO
    {
        private hkpTaskSheetFacilityFacade facade = hkpTaskSheetFacilityFacade.Instance;
        protected static hkpTaskSheetFacilityBO instance = new hkpTaskSheetFacilityBO();

        protected hkpTaskSheetFacilityBO()
        {
            this.baseFacade = facade;
        }

        public static hkpTaskSheetFacilityBO Instance
        {
            get { return instance; }
        }
    }
}
