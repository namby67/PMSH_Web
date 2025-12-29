using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class StateFacade : BaseFacadeDB
    {
        protected static StateFacade instance = new StateFacade(new StateModel());
        protected StateFacade(StateModel model) : base(model)
        {
        }
        public static StateFacade Instance
        {
            get { return instance; }
        }
        protected StateFacade() : base()
        {
        }
    }
}
