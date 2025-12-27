using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class BusinessBlockFacade : BaseFacadeDB
    {
        protected static BusinessBlockFacade instance = new BusinessBlockFacade(new BusinessBlockModel());
        protected BusinessBlockFacade(BusinessBlockModel model) : base(model)
        {
        }
        public static BusinessBlockFacade Instance
        {
            get { return instance; }
        }
        protected BusinessBlockFacade() : base()
        {
        }
    }
}
