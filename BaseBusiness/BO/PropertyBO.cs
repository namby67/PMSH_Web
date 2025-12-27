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
    public class PropertyBO : BaseBO
    {
        private PropertyFacade facade = PropertyFacade.Instance;
        protected static PropertyBO instance = new PropertyBO();

        protected PropertyBO()
        {
            this.baseFacade = facade;
        }

        public static PropertyBO Instance
        {
            get { return instance; }
        }
        public PropertyTypeModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, PropertyTypeID ,PropertyCode, PropertyName, Telephone, Fax, Email, Website, Address, ServerName, DatabaseName, Login, Password, Inactive, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM Property WHERE ID = @id";
            return conn.QuerySingleOrDefault<PropertyTypeModel>(sql, new { id }, tx);
        }
    }
   
}
