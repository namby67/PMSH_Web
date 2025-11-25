using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class PropertyPermissionFacade : BaseFacadeDB
    {
        protected static PropertyPermissionFacade instance = new PropertyPermissionFacade(new PropertyPermissionModel());
        protected PropertyPermissionFacade(PropertyPermissionModel model) : base(model)
        {
        }
        public static PropertyPermissionFacade Instance
        {
            get { return instance; }
        }
        protected PropertyPermissionFacade() : base()
        {
        }
    
    }
}
