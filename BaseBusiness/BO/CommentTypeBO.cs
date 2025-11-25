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
    public class CommentTypeBO : BaseBO
    {
        private CommentTypeFacade facade = CommentTypeFacade.Instance;
        protected static CommentTypeBO instance = new CommentTypeBO();

        protected CommentTypeBO()
        {
            this.baseFacade = facade;
        }

        public static CommentTypeBO Instance
        {
            get { return instance; }
        }
        public CommentTypeModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM CommentType WHERE ID = @id";
            return conn.QuerySingleOrDefault<CommentTypeModel>(sql, new { id }, tx);
        }
    }
}
