using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.util;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class RateCodeBO : BaseBO
    {
        private RateCodeFacade facade = RateCodeFacade.Instance;
        protected static RateCodeBO instance = new RateCodeBO();

        protected RateCodeBO()
        {
            this.baseFacade = facade;
        }

        public static RateCodeBO Instance
        {
            get { return instance; }
        }
        public static DataTable RatecodebyDate(DateTime fromDate, DateTime toDate, string ratecode)
        {
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate),
                new SqlParameter("@strRateCode", ratecode),
                       new SqlParameter("@strCurrency", "USD"),
                           new SqlParameter("@strRooTypeCode", ""),
            };

            DataTable myTable = DataTableHelper.getTableData("spRptRevenue_RateCodeByDateReport", param);
            return myTable;
        }
    }
}
