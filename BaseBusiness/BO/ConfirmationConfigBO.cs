using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ConfirmationConfigBO : BaseBO
    {
        private ConfirmationConfigFacade facade = ConfirmationConfigFacade.Instance;
        protected static ConfirmationConfigBO instance = new ConfirmationConfigBO();

        protected ConfirmationConfigBO()
        {
            this.baseFacade = facade;
        }

        public static ConfirmationConfigBO Instance
        {
            get { return instance; }
        }
    }
}
