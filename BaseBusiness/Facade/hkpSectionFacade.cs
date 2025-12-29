using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpSectionFacade : BaseFacadeDB
    {
        protected static hkpSectionFacade instance = new hkpSectionFacade(new hkpSectionModel());
        protected hkpSectionFacade(hkpSectionModel model) : base(model)
        {
        }
        public static hkpSectionFacade Instance
        {
            get { return instance; }
        }
        protected hkpSectionFacade() : base()
        {
        }
    }
}
