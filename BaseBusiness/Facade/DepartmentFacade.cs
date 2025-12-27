using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class DepartmentFacade : BaseFacadeDB
    {
        protected static DepartmentFacade instance = new DepartmentFacade(new DepartmentModel());
        protected DepartmentFacade(DepartmentModel model) : base(model)
        {
        }
        public static DepartmentFacade Instance
        {
            get { return instance; }
        }
        protected DepartmentFacade() : base()
        {
        }
    }
}
