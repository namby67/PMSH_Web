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
    public class TerritoryBO : BaseBO
    {
        private TerritoryFacade facade = TerritoryFacade.Instance;
        protected static TerritoryBO instance = new TerritoryBO();

        protected TerritoryBO()
        {
            this.baseFacade = facade;
        }

        public static TerritoryBO Instance
        {
            get { return instance; }
        }
    }
}
