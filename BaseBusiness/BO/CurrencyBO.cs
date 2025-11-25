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
    public class CurrencyBO : BaseBO
    {
        private CurrencyFacade facade = CurrencyFacade.Instance;
        protected static CurrencyBO instance = new CurrencyBO();

        protected CurrencyBO()
        {
            this.baseFacade = facade;
        }

        public static CurrencyBO Instance
        {
            get { return instance; }
        }
        public CurrencyModel GetById(string id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, MasterStatus, IsShow, Inactive, Decimals, Description, UserInsertID, CreateDate,  UserUpdateID, UpdateDate FROM Currency WHERE ID = @id";
            return conn.QuerySingleOrDefault<CurrencyModel>(sql, new { id }, tx);
        }

    }
}
