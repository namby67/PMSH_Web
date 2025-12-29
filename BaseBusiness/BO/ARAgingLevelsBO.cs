using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ARAgingLevelsBO : BaseBO
    {
        private ARAgingLevelsFacade facade = ARAgingLevelsFacade.Instance;
        protected static ARAgingLevelsBO instance = new ARAgingLevelsBO();

        protected ARAgingLevelsBO()
        {
            this.baseFacade = facade;
        }

        public static ARAgingLevelsBO Instance
        {
            get { return instance; }
        }
    }
}
