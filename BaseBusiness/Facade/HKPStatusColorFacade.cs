using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    internal class HKPStatusColorFacade : BaseFacadeDB
    {
        protected static HKPStatusColorFacade instance = new HKPStatusColorFacade(new HKPStatusColorModel());
        protected HKPStatusColorFacade(HKPStatusColorModel model) : base(model)
        {
        }
        public static HKPStatusColorFacade Instance
        {
            get { return instance; }
        }
        protected HKPStatusColorFacade() : base()
        {
        }
    
    }
}
