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
    public class MemberCategoryBO : BaseBO
    {
        private MemberCategoryFacade facade = MemberCategoryFacade.Instance;
        protected static MemberCategoryBO instance = new MemberCategoryBO();

        protected MemberCategoryBO()
        {
            this.baseFacade = facade;
        }

        public static MemberCategoryBO Instance
        {
            get { return instance; }
        }
        public MemberCategoryModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM MemberCategory WHERE ID = @id";
            return conn.QuerySingleOrDefault<MemberCategoryModel>(sql, new { id }, tx);
        }
    }
}
