using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class RateCodeFacade : BaseFacadeDB
    {
        protected static RateCodeFacade instance = new RateCodeFacade(new RateCodeModel());
        protected RateCodeFacade(RateCodeModel model) : base(model)
        {
        }
        public static RateCodeFacade Instance
        {
            get { return instance; }
        }
        protected RateCodeFacade() : base()
        {
        }
    }
}
