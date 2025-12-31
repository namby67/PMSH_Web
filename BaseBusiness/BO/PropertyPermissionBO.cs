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
    public class PropertyPermissionBO : BaseBO
    {
        private PropertyPermissionFacade facade = PropertyPermissionFacade.Instance;
        protected static PropertyPermissionBO instance = new PropertyPermissionBO();

        protected PropertyPermissionBO()
        {
            this.baseFacade = facade;
        }

        public static PropertyPermissionBO Instance
        {
            get { return instance; }
        }
    }

}
