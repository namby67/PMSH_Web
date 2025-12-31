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
    public class PropertyTypeBO : BaseBO


    {
        private PropertyTypeFacade facade = PropertyTypeFacade.Instance;
        protected static PropertyTypeBO instance = new PropertyTypeBO();

        protected PropertyTypeBO()
        {
            this.baseFacade = facade;
        }

        public static PropertyTypeBO Instance
        {
            get { return instance; }
        }

    }
}
