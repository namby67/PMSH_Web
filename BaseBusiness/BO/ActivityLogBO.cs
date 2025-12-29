using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ActivityLogBO : BaseBO
    {
        private ActivityLogFacade facade = ActivityLogFacade.Instance;
        protected static ActivityLogBO instance = new ActivityLogBO();

        protected ActivityLogBO()
        {
            this.baseFacade = facade;
        }

        public static ActivityLogBO Instance
        {
            get { return instance; }
        }
    }
}
