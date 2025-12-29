using BaseBusiness.BO;
using BaseBusiness.util;
using Billing.Services.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Services.Implements
{
    public class TransferTransactionService : ITransferTransactionService
    {
        public DataTable SearchGuestInRoom(string room, string name)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@Room", room),

                     new SqlParameter("@Name", name),

                };

                DataTable myTable = DataTableHelper.getTableData("spSearchGuestInRoom", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
