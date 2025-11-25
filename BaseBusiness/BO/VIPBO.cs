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
    public class VIPBO : BaseBO
    {
        private VIPFacade facade = VIPFacade.Instance;
        protected static VIPBO instance = new VIPBO();

        protected VIPBO()
        {
            this.baseFacade = facade;
        }

        public static VIPBO Instance
        {
            get { return instance; }
        }
        public VIPModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM VIP WHERE ID = @id";
            return conn.QuerySingleOrDefault<VIPModel>(sql, new { id }, tx);
        }
    }
}
