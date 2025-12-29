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
    public class PickupDropPlaceBO : BaseBO
    {
        private PickupDropPlaceFacade facade = PickupDropPlaceFacade.Instance;
        protected static PickupDropPlaceBO instance = new PickupDropPlaceBO();

        protected PickupDropPlaceBO()
        {
            this.baseFacade = facade;
        }

        public static PickupDropPlaceBO Instance
        {
            get { return instance; }
        }
        public PickupDropPlaceModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, Description, CreatedBy, CreatedDate,  UpdatedBy, UpdatedDate FROM PickupDropPlace WHERE ID = @id";
            return conn.QuerySingleOrDefault<PickupDropPlaceModel>(sql, new { id }, tx);
        }
    }
}
