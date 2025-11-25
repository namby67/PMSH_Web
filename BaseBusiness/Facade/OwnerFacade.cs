using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class OwnerFacade : BaseFacadeDB
    {
        protected static OwnerFacade instance = new OwnerFacade(new OwnerModel());
        protected OwnerFacade(OwnerModel model) : base(model)
        {
        }
        public static OwnerFacade Instance
        {
            get { return instance; }
        }
        protected OwnerFacade() : base()
        {
        }
    }
}
