using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class UserGroupRightDistributionFacade : BaseFacadeDB
    {
        protected static UserGroupRightDistributionFacade instance = new UserGroupRightDistributionFacade(new UserGroupRightDistributionModel());
        protected UserGroupRightDistributionFacade(UserGroupRightDistributionModel model) : base(model)
        {
        }
        public static UserGroupRightDistributionFacade Instance
        {
            get { return instance; }
        }
        protected UserGroupRightDistributionFacade() : base()
        {
        }
    }
}
