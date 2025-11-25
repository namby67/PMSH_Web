using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpAttendantFacade : BaseFacadeDB
    {
        protected static hkpAttendantFacade instance = new hkpAttendantFacade(new hkpAttendantModel());
        protected hkpAttendantFacade(hkpAttendantModel model) : base(model)
        {
        }
        public static hkpAttendantFacade Instance
        {
            get { return instance; }
        }
        protected hkpAttendantFacade() : base()
        {
        }
    }
}
