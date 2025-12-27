using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpTaskSheetFacilityFacade : BaseFacadeDB
    {
        protected static hkpTaskSheetFacilityFacade instance = new hkpTaskSheetFacilityFacade(new hkpTaskSheetFacilityModel());
        protected hkpTaskSheetFacilityFacade(hkpTaskSheetFacilityModel model) : base(model)
        {
        }
        public static hkpTaskSheetFacilityFacade Instance
        {
            get { return instance; }
        }
        protected hkpTaskSheetFacilityFacade() : base()
        {
        }
    }
}
