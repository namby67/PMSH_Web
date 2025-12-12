using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class OccupancyBO : BaseBO
    {
        private OccupancyFacade facade = OccupancyFacade.Instance;
        protected static OccupancyBO instance = new OccupancyBO();

        protected OccupancyBO()
        {
            this.baseFacade = facade;
        }

        public static OccupancyBO Instance
        {
            get { return instance; }
        }
    }
}
