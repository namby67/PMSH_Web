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
    public class NationalityBO: BaseBO
    {
        private NationalityFacade facade = NationalityFacade.Instance;
        protected static NationalityBO instance = new NationalityBO();

        protected NationalityBO()
        {
            this.baseFacade = facade;
        }

        public static NationalityBO Instance
        {
            get { return instance; }
        }
    }
}
