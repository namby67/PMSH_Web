using Administration.Services.Interfaces;
using BaseBusiness.BO;
using BaseBusiness.util;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Administration.Services.Implements
{
    public class EmailService : IEmailService
    {
        public DataTable GetAllEmailOfGuest(DateTime fromDate, DateTime toDate, int status)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
            new SqlParameter("@FromDate", fromDate),
            new SqlParameter("@ToDate", toDate),     
            new SqlParameter("@Status", status),                 
                };
                DataTable myTable = DataTableHelper.getTableData("GetGuestOfMail", param);
                return myTable;
            }
            catch (SqlException ex)
            {
                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
