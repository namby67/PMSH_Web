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
    public class CountryBO : BaseBO
    {
        private CountryFacade facade = CountryFacade.Instance;
        protected static CountryBO instance = new CountryBO();

        protected CountryBO()
        {
            this.baseFacade = facade;
        }

        public static CountryBO Instance
        {
            get { return instance; }
        }
        public CountryModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM Country WHERE ID = @id";
            return conn.QuerySingleOrDefault<CountryModel>(sql, new { id }, tx);
        }
    }
}
