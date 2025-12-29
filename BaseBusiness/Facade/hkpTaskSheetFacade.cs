using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpTaskSheetFacade : BaseFacadeDB
    {
        protected static hkpTaskSheetFacade instance = new hkpTaskSheetFacade(new hkpTaskSheetModel());
        protected hkpTaskSheetFacade(hkpTaskSheetModel model) : base(model)
        {
        }
        public static hkpTaskSheetFacade Instance
        {
            get { return instance; }
        }
        protected hkpTaskSheetFacade() : base()
        {
        }
    }
}
