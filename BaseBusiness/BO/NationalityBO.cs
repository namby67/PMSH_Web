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
    public class NationalityBO: BaseBO
    {
        private NationalityFacade facade = NationalityFacade.Instance;
        protected static NationalityBO instance = new NationalityBO();

        protected NationalityBO()
        {
            this.baseFacade = facade;
        }

        public static NationalityBO Instance
        {
            get { return instance; }
        }
        public TitleModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM Nationality WHERE ID = @id";
            return conn.QuerySingleOrDefault<TitleModel>(sql, new { id }, tx);
        }
    }
}
