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
    public class AlertsSetupBO : BaseBO
    {
        private AlertsSetupFacade facade = AlertsSetupFacade.Instance;
        protected static AlertsSetupBO instance = new AlertsSetupBO();

        protected AlertsSetupBO()
        {
            this.baseFacade = facade;
        }

        public static AlertsSetupBO Instance
        {
            get { return instance; }
        }
        public AlertsSetupModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM AlertsSetup WHERE ID = @id";
            return conn.QuerySingleOrDefault<AlertsSetupModel>(sql, new { id }, tx);
        }
    }
}
