using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpAttendantPointFacade : BaseFacadeDB
    {
        protected static hkpAttendantPointFacade instance = new hkpAttendantPointFacade(new hkpAttendantPointModel());
        protected hkpAttendantPointFacade(hkpAttendantPointModel model) : base(model)
        {
        }
        public static hkpAttendantPointFacade Instance
        {
            get { return instance; }
        }
        protected hkpAttendantPointFacade() : base()
        {
        }
    }
}
