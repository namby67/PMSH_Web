using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpFacilityCodeFacade : BaseFacadeDB
    {
        protected static hkpFacilityCodeFacade instance = new hkpFacilityCodeFacade(new hkpFacilityCodeModel());
        protected hkpFacilityCodeFacade(hkpFacilityCodeModel model) : base(model)
        {
        }
        public static hkpFacilityCodeFacade Instance
        {
            get { return instance; }
        }
        protected hkpFacilityCodeFacade() : base()
        {
        }
    }
}
