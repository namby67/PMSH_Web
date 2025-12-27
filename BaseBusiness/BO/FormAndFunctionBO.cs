using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class FormAndFunctionBO : BaseBO
    {
        private FormAndFunctionFacade facade = FormAndFunctionFacade.Instance;
        protected static FormAndFunctionBO instance = new FormAndFunctionBO();

        protected FormAndFunctionBO()
        {
            this.baseFacade = facade;
        }

        public static FormAndFunctionBO Instance
        {
            get { return instance; }
        }
    }
}
