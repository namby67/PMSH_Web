using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class hkpEmployeeFacade : BaseFacadeDB
    {
        protected static hkpEmployeeFacade instance = new hkpEmployeeFacade(new hkpEmployeeModel());
        protected hkpEmployeeFacade(hkpEmployeeModel model) : base(model)
        {
        }
        public static hkpEmployeeFacade Instance
        {
            get { return instance; }
        }
        protected hkpEmployeeFacade() : base()
        {
        }
    }
}
