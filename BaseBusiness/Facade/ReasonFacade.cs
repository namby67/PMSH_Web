using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReasonFacade : BaseFacadeDB
    {
        protected static ReasonFacade instance = new ReasonFacade(new ReasonModel());
        protected ReasonFacade(ReasonModel model) : base(model)
        {
        }
        public static ReasonFacade Instance
        {
            get { return instance; }
        }
        protected ReasonFacade() : base()
        {
        }
    }
}
