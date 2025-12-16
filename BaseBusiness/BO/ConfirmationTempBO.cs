using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ConfirmationTempBO : BaseBO
    {
        private ConfirmationTempFacade facade = ConfirmationTempFacade.Instance;
        protected static ConfirmationTempBO instance = new ConfirmationTempBO();

        protected ConfirmationTempBO()
        {
            this.baseFacade = facade;
        }

        public static ConfirmationTempBO Instance
        {
            get { return instance; }
        }
    }
}
