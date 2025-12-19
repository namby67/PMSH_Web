using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using Microsoft.Data.SqlClient;

namespace BaseBusiness.BO
{
    using Dapper;
    public class DepartmentBO : BaseBO
    {
        private DepartmentFacade facade = DepartmentFacade.Instance;
        protected static DepartmentBO instance = new DepartmentBO();

        protected DepartmentBO()
        {
            this.baseFacade = facade;
        }

        public static DepartmentBO Instance
        {
            get { return instance; }
        }
        
    }
}
