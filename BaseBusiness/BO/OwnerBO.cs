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
    public class OwnerBO : BaseBO
    {
        private OwnerFacade facade = OwnerFacade.Instance;
        protected static OwnerBO instance = new OwnerBO();

        protected OwnerBO()
        {
            this.baseFacade = facade;
        }

        public static OwnerBO Instance
        {
            get { return instance; }
        }
    }
}
