using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class OriginFacade : BaseFacadeDB
    {
        protected static OriginFacade instance = new OriginFacade(new OriginModel());
        protected OriginFacade(OriginModel model) : base(model)
        {
        }
        public static OriginFacade Instance
        {
            get { return instance; }
        }
        protected OriginFacade() : base()
        {
        }
    }
}
