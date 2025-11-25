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
    public class SeasonBO : BaseBO
    {
        private SeasonFacade facade = SeasonFacade.Instance;
        protected static SeasonBO instance = new SeasonBO();

        protected SeasonBO()
        {
            this.baseFacade = facade;
        }

        public static SeasonBO Instance
        {
            get { return instance; }
        }
        public SeasonModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM Season WHERE ID = @id";
            return conn.QuerySingleOrDefault<SeasonModel>(sql, new { id }, tx);
        }
    }
}
