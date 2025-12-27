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
    public class MarketBO : BaseBO
    {
        private MarketFacade facade = MarketFacade.Instance;
        protected static MarketBO instance = new MarketBO();

        protected MarketBO()
        {
            this.baseFacade = facade;
        }

        public static MarketBO Instance
        {
            get { return instance; }
        }
        public MarketModel GetById(int id)
        {
            string sql = @"SELECT 
                      Id, Code, Name, Description, Inactive, 
                      MarketTypeID, Regional, GroupType,
                      CreatedBy, CreatedDate, UpdatedBy, UpdatedDate
                   FROM Market
                   WHERE Id = @Id";

            return GetFirst<MarketModel>(sql, new { Id = id });
        }
        public MarketModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM Market WHERE ID = @id";
            return conn.QuerySingleOrDefault<MarketModel>(sql, new { id }, tx);
        }
    }
}
