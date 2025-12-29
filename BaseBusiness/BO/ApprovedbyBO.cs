using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ApprovedbyBO : BaseBO
    {
        private ApprovedbyFacade facade = ApprovedbyFacade.Instance;
        protected static ApprovedbyBO instance = new ApprovedbyBO();

        protected ApprovedbyBO()
        {
            this.baseFacade = facade;
        }

        public static ApprovedbyBO Instance
        {
            get { return instance; }
        }
    }
}
