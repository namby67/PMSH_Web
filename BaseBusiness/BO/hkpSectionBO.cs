using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class hkpSectionBO : BaseBO
    {
        private hkpSectionFacade facade = hkpSectionFacade.Instance;
        protected static hkpSectionBO instance = new hkpSectionBO();

        protected hkpSectionBO()
        {
            this.baseFacade = facade;
        }

        public static hkpSectionBO Instance
        {
            get { return instance; }
        }
    }
}
