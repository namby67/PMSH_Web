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
    public class ReservationTypeBO : BaseBO
    {
        private ReservationTypeFacade facade = ReservationTypeFacade.Instance;
        protected static ReservationTypeBO instance = new ReservationTypeBO();

        protected ReservationTypeBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationTypeBO Instance
        {
            get { return instance; }
        }
        public ReservationTypeModel GetById(int id, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = "SELECT ID, Code, Name, UserInsertID, CreateDate,  UserUpdateID, UpdateDate FROM ReservationType WHERE ID = @id";
            return conn.QuerySingleOrDefault<ReservationTypeModel>(sql, new { id }, tx);
        }
    }
}
