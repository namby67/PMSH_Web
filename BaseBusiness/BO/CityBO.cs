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
    public class CityBO : BaseBO
    {
        private CityFacade facade = CityFacade.Instance;
        protected static CityBO instance = new CityBO();

        protected CityBO()
        {
            this.baseFacade = facade;
        }

        public static CityBO Instance
        {
            get { return instance; }
        }
        public CityModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM City WHERE ID = @id";
            return conn.QuerySingleOrDefault<CityModel>(sql, new { id }, tx);
        }
    }
}
