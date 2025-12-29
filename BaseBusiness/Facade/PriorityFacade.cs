using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PriorityFacade : BaseFacadeDB
    {
        protected static PriorityFacade instance = new PriorityFacade(new PriorityModel());
        protected PriorityFacade(PriorityModel model) : base(model)
        {
        }
        public static PriorityFacade Instance
        {
            get { return instance; }
        }
        protected PriorityFacade() : base()
        {
        }
    }
}
