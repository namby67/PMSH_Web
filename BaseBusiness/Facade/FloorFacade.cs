using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class FloorFacade : BaseFacadeDB
    {
        protected static FloorFacade instance = new FloorFacade(new FloorModel());
        protected FloorFacade(FloorModel model) : base(model)
        {
        }
        public static FloorFacade Instance
        {
            get { return instance; }
        }
        protected FloorFacade() : base()
        {
        }
    }
}
