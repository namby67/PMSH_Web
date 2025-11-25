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
    public class TransportTypeBO : BaseBO
    {
        private TransportTypeFacade facade = TransportTypeFacade.Instance;
        protected static TransportTypeBO instance = new TransportTypeBO();

        protected TransportTypeBO()
        {
            this.baseFacade = facade;
        }

        public static TransportTypeBO Instance
        {
            get { return instance; }
        }
        public TransportTypeModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM TransportType WHERE ID = @id";
            return conn.QuerySingleOrDefault<TransportTypeModel>(sql, new { id }, tx);
        }
    }
}
