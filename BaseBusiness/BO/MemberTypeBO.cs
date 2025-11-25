using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.Data.SqlClient;

namespace BaseBusiness.BO
{
    using Dapper;
    public class MemberTypeBO : BaseBO
    {
        private MemberTypeFacade facade = MemberTypeFacade.Instance;
        protected static MemberTypeBO instance = new MemberTypeBO();

        protected MemberTypeBO()
        {
            this.baseFacade = facade;
        }

        public static MemberTypeBO Instance
        {
            get { return instance; }
        }
        public string GetDescriptionById(int id)
        {
            if (id <= 0) return null;

            string description = null;
            string sql = "SELECT Description FROM MemberType WHERE ID = @ID";

            using (SqlConnection conn = new SqlConnection(DBUtils.GetDBConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        description = result.ToString();
                }
            }

            return description;
        }
        public MemberTypeModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM MemberType WHERE ID = @id";
            return conn.QuerySingleOrDefault<MemberTypeModel>(sql, new { id }, tx);
        }

    }
}
