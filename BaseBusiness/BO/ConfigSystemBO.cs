using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace BaseBusiness.BO
{
    using Dapper;
    public class ConfigSystemBO :  BaseBO
    {
        private ConfigSystemFacade facade = ConfigSystemFacade.Instance;
        protected static ConfigSystemBO instance = new ConfigSystemBO();

        protected ConfigSystemBO()
        {
            this.baseFacade = facade;
        }

        public static ConfigSystemBO Instance
        {
            get { return instance; }
        }

        public static string GetConfigETA()
        {
            string query = " select KeyValue from ConfigSystem where KeyName = 'ETA'";
            return instance.GetFirst<string>(query);
        }
        public static string GetConfigETD()
        {
            string query = " select KeyValue from ConfigSystem where KeyName = 'ETD'";
            return instance.GetFirst<string>(query);
        }
        public static string GetConfigDesciption()
        {
            string query = " Select Desciption From ConfigSystem Where KeyName = 'Msg'";
            return instance.GetFirst<string>(query);
        }
        public int UpdateMsg(string desciption, int userUpdateId, SqlConnection conn = null, SqlTransaction tx = null)
        {
            const string sql = @"
                UPDATE ConfigSystem
                SET 
                    Desciption   = @Desciption,
                    UserUpdateID = @UserUpdateID,
                    UpdateDate   = @UpdateDate
                WHERE KeyName = 'Msg'";

            return conn.Execute(sql, new
            {
                Desciption = desciption,
                UserUpdateID = userUpdateId,
                UpdateDate = DateTime.Now
            }, tx);
        }

    }
}
