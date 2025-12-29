using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace BaseBusiness.BO
{
    using Dapper;
    public class CommentBO : BaseBO
    {

        private CommentFacade facade = CommentFacade.Instance;
        protected static CommentBO instance = new CommentBO();

        protected CommentBO()
        {
            this.baseFacade = facade;
        }

        public static CommentBO Instance
        {
            get { return instance; }
        }

        public static List<CommentModel> GetReasonAdjust()
        {
            string query = $"SELECT * FROM Comment where CommentTypeID = 8 and Inactive = 0";
            return instance.GetList<CommentModel>(query);
        }
        public CommentModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM Comment WHERE ID = @id";
            return conn.QuerySingleOrDefault<CommentModel>(sql, new { id }, tx);
        }
    }
}
