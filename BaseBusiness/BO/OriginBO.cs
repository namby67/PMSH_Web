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
    public class OriginBO : BaseBO
    {
        private OriginFacade facade = OriginFacade.Instance;
        protected static OriginBO instance = new OriginBO();

        protected OriginBO()
        {
            this.baseFacade = facade;
        }

        public static OriginBO Instance
        {
            get { return instance; }
        }
        public OriginModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM  Origin WHERE ID = @id";
            return conn.QuerySingleOrDefault<OriginModel>(sql, new { id }, tx);
        }
    }
}
