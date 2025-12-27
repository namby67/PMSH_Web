using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class OverbookingFacade : BaseFacadeDB
    {
        protected static OverbookingFacade instance = new OverbookingFacade(new OverbookingModel());
        protected OverbookingFacade(OverbookingModel model) : base(model)
        {
        }
        public static OverbookingFacade Instance
        {
            get { return instance; }
        }
        protected OverbookingFacade() : base()
        {
        }
    }
}
