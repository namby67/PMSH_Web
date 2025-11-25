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
    public class ReasonBO : BaseBO
    {
        private ReasonFacade facade = ReasonFacade.Instance;
        protected static ReasonBO instance = new ReasonBO();

        protected ReasonBO()
        {
            this.baseFacade = facade;
        }

        public static ReasonBO Instance
        {
            get { return instance; }
        }
        public ReasonModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM Reason WHERE ID = @id";
            return conn.QuerySingleOrDefault<ReasonModel>(sql, new { id }, tx);
        }
    }
}
