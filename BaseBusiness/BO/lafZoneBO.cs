using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class lafZoneBO : BaseBO
    {
        private lafZoneFacade facade = lafZoneFacade.Instance;
        protected static lafZoneBO instance = new lafZoneBO();

        protected lafZoneBO()
        {
            this.baseFacade = facade;
        }

        public static lafZoneBO Instance
        {
            get { return instance; }
        }
    }
}
