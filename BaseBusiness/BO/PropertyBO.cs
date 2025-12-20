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
    public class PropertyBO : BaseBO
    {
        private PropertyFacade facade = PropertyFacade.Instance;
        protected static PropertyBO instance = new PropertyBO();

        protected PropertyBO()
        {
            this.baseFacade = facade;
        }

        public static PropertyBO Instance
        {
            get { return instance; }
        }
    }
   
}
