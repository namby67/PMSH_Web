using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class FloorBO : BaseBO
    {
        private FloorFacade facade = FloorFacade.Instance;
        protected static FloorBO instance = new FloorBO();

        protected FloorBO()
        {
            this.baseFacade = facade;
        }

        public static FloorBO Instance
        {
            get { return instance; }
        }
    }
}
