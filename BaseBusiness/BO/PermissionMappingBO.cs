using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PermissionMappingBO : BaseBO
    {
        private PermissionMappingFacade facade = PermissionMappingFacade.Instance;
        protected static PermissionMappingBO instance = new PermissionMappingBO();

        protected PermissionMappingBO()
        {
            this.baseFacade = facade;
        }

        public static PermissionMappingBO Instance
        {
            get { return instance; }
        }
    }
}
