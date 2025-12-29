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
    public class HKPStatusColorBO : BaseBO
    {
        private HKPStatusColorFacade facade = HKPStatusColorFacade.Instance;
        protected static HKPStatusColorBO instance = new HKPStatusColorBO();

        protected HKPStatusColorBO()
        {
            this.baseFacade = facade;
        }

        public static HKPStatusColorBO Instance
        {
            get { return instance; }
        }
        public HKPStatusColorModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, StatusName, ColorName, FontColorName, Description, UserInsertID, UserUpdateID,  CreateDate, UpdateDate FROM HKPStatusColor WHERE ID = @id";
            return conn.QuerySingleOrDefault<HKPStatusColorModel>(sql, new { id }, tx);
        }
    
    }
}
