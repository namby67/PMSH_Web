using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpTaskSheetDetailFacade : BaseFacadeDB
    {
        protected static hkpTaskSheetDetailFacade instance = new hkpTaskSheetDetailFacade(new hkpTaskSheetDetailModel());
        protected hkpTaskSheetDetailFacade(hkpTaskSheetDetailModel model) : base(model)
        {
        }
        public static hkpTaskSheetDetailFacade Instance
        {
            get { return instance; }
        }
        protected hkpTaskSheetDetailFacade() : base()
        {
        }
    }
}
