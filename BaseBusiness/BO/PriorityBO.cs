using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PriorityBO : BaseBO
    {
        private PriorityFacade facade = PriorityFacade.Instance;
        protected static PriorityBO instance = new PriorityBO();

        protected PriorityBO()
        {
            this.baseFacade = facade;
        }

        public static PriorityBO Instance
        {
            get { return instance; }
        }
    }
}
