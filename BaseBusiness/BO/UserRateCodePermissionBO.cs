using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class UserRateCodePermissionBO : BaseBO
    {
        private UserRateCodePermissionFacade facade = UserRateCodePermissionFacade.Instance;
        protected static UserRateCodePermissionBO instance = new UserRateCodePermissionBO();

        protected UserRateCodePermissionBO()
        {
            this.baseFacade = facade;
        }

        public static UserRateCodePermissionBO Instance
        {
            get { return instance; }
        }
    }
}
