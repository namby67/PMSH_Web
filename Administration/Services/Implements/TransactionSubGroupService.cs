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
    public class TransactionSubGroupService : ITransactionSubGroupService
    {
        public DataTable SearchTransactionSubGroup(string groupCode, string description,int groupID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@SubGroupCode", groupCode),
                new SqlParameter("@SubGroupDescription", description),
                new SqlParameter("@GroupID", groupID),

                };
                DataTable myTable = DataTableHelper.getTableData("spSearchTransactionSubGroup", param);
                return myTable;
            }
            catch (SqlException ex)
            {
                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
