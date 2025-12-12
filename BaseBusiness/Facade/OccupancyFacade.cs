using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class OccupancyFacade : BaseFacadeDB
    {
        protected static OccupancyFacade instance = new OccupancyFacade(new OccupancyModel());
        protected OccupancyFacade(OccupancyModel model) : base(model)
        {
        }
        public static OccupancyFacade Instance
        {
            get { return instance; }
        }
        protected OccupancyFacade() : base()
        {
        }
    }
}
