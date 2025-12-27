using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;
namespace BaseBusiness.Facade
{
    public class BusinessDateFacade : BaseFacadeDB
    {
        protected static BusinessDateFacade instance = new BusinessDateFacade(new BusinessDateModel());
        protected BusinessDateFacade(BusinessDateModel model) : base(model)
        {
        }
        public static BusinessDateFacade Instance
        {
            get { return instance; }
        }
        protected BusinessDateFacade() : base()
        {
        }
    }
}
