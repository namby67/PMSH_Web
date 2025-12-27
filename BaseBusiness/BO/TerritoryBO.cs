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
        public TerritoryModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM Territory WHERE ID = @id";
            return conn.QuerySingleOrDefault<TerritoryModel>(sql, new { id }, tx);
        }
    }
}
