using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ARAccountReceivableBO : BaseBO
    {
        private ARAccountReceivableFacade facade = ARAccountReceivableFacade.Instance;
        protected static ARAccountReceivableBO instance = new ARAccountReceivableBO();

        protected ARAccountReceivableBO()
        {
            this.baseFacade = facade;
        }

        public static ARAccountReceivableBO Instance
        {
            get { return instance; }
        }
    }
}
