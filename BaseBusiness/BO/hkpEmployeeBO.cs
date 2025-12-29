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
    public class hkpEmployeeBO : BaseBO
    {
        private hkpEmployeeFacade facade = hkpEmployeeFacade.Instance;
        protected static hkpEmployeeBO instance = new hkpEmployeeBO();

        protected hkpEmployeeBO()
        {
            this.baseFacade = facade;
        }

        public static hkpEmployeeBO Instance
        {
            get { return instance; }
        }

        public static List<hkpEmployeeModel> GetEmployee()
        {
            string query = "Select * from hkpEmployee where ((ID like N'%') or (Name like N'%')) AND Inactive = 0 Order by ID";

          

            return instance.GetList<hkpEmployeeModel>(query);
        }
        public hkpEmployeeModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Description, Name, IsActive,CreatedDate , CreatedBy, UpdatedBy,UpdatedDate, Inactive FROM hkpEmployee WHERE ID = @id";
            return conn.QuerySingleOrDefault<hkpEmployeeModel>(sql, new { id }, tx);
        }
    }
}
