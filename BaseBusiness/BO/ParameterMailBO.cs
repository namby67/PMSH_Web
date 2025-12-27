using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ParameterMailBO : BaseBO
    {
        private ParameterMailFacade facade = ParameterMailFacade.Instance;
        protected static ParameterMailBO instance = new ParameterMailBO();

        protected ParameterMailBO()
        {
            this.baseFacade = facade;
        }

        public static ParameterMailBO Instance
        {
            get { return instance; }
        }
    }
}
