using Administration.Services.Interfaces;
using BaseBusiness.util;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Services.Implements
{
    public class TransactionGroupService : ITransactionGroupService
    {
        public DataTable SearchTransactionGroup(string groupCode, string description)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@GroupCode", groupCode),
                new SqlParameter("@GroupDescription", description),
                };
                DataTable myTable = DataTableHelper.getTableData("spSearchTransactionGroup", param);
                return myTable;
            }
            catch (SqlException ex)
            {
                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
