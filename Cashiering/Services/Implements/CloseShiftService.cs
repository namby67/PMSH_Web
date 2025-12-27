using BaseBusiness.BO;
using BaseBusiness.util;
using Cashiering.Services.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cashiering.Services.Implements
{
    public class CloseShiftService : ICloseShiftService
    {
        public DataTable GetCloseShift(int shiftID, int type)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ShiftID", shiftID),

                     new SqlParameter("@Type", type),



                };

                DataTable myTable = DataTableHelper.getTableData("spSearchTransactionCloseShift_New", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
