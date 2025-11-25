using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class InterfaceBO : BaseBO
    {
        private InterfaceFacade facade = InterfaceFacade.Instance;
        protected static InterfaceBO instance = new InterfaceBO();

        protected InterfaceBO()
        {
            this.baseFacade = facade;
        }

        public static InterfaceBO Instance
        {
            get { return instance; }
        }
    }
}
