using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class UserGroupRightDistributionBO : BaseBO
    {
        private UserGroupRightDistributionFacade facade = UserGroupRightDistributionFacade.Instance;
        protected static UserGroupRightDistributionBO instance = new UserGroupRightDistributionBO();

        protected UserGroupRightDistributionBO()
        {
            this.baseFacade = facade;
        }

        public static UserGroupRightDistributionBO Instance
        {
            get { return instance; }
        }
    }
}
