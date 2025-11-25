using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PermissionMappingFacade : BaseFacadeDB
    {
        protected static PermissionMappingFacade instance = new PermissionMappingFacade(new PermissionMappingModel());
        protected PermissionMappingFacade(PermissionMappingModel model) : base(model)
        {
        }
        public static PermissionMappingFacade Instance
        {
            get { return instance; }
        }
        protected PermissionMappingFacade() : base()
        {
        }
    }
}
