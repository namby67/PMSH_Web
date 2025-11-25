using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class UserRateCodePermissionFacade : BaseFacadeDB
    {
        protected static UserRateCodePermissionFacade instance = new UserRateCodePermissionFacade(new UserRateCodePermissionModel());
        protected UserRateCodePermissionFacade(UserRateCodePermissionModel model) : base(model)
        {
        }
        public static UserRateCodePermissionFacade Instance
        {
            get { return instance; }
        }
        protected UserRateCodePermissionFacade() : base()
        {
        }
    }
}
