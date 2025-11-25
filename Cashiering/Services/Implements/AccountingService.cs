using BaseBusiness.BO;
using BaseBusiness.util;
using Cashiering.Services.Interfaces;
using DevExpress.Web;
using Microsoft.Data.SqlClient;

using System.Data;
using System.Data.SqlClient;
using SqlException = Microsoft.Data.SqlClient.SqlException;
using SqlParameter = Microsoft.Data.SqlClient.SqlParameter;


namespace Cashiering.Services.Implements
{
    public class AccountingService : IAccountingService
    {
        public DataTable AccountMaintence(int arID, string folioNo, string isActive, string paymentOnly, string print, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ARID", arID),
                    new SqlParameter("@FolioNo", folioNo),
                    new SqlParameter("@IsActive", isActive),
                    new SqlParameter("@PaymentOnly",paymentOnly),
                    new SqlParameter("@Print",print),
                    new SqlParameter("@FromDate",fromDate ),
                    new SqlParameter("@ToDate",  toDate),
                };

                DataTable myTable = DataTableHelper.getTableData("spARAccountReceivableTransSearch", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable AccountSearch(string accountName, string accountNo, int accountType, string balance)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@AccountName", accountName ?? ""),

                     new SqlParameter("@AccountNo", accountNo ?? ""),
                    new SqlParameter("@AccountTypeID", accountType),
                     new SqlParameter("@Balance", balance ?? ""),



                };

                DataTable myTable = DataTableHelper.getTableData("spARAccountReceivableSearch", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable InvoiceSearch(int folioID, int mode)
        {
          try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@FolioID", folioID),
                    new SqlParameter("@Mode", mode),

                };

                DataTable myTable = DataTableHelper.getTableData("spSearchTransactionInFolioByDev ", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }        
        }

        public DataTable SearchByCommmand(string sqlCommand)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@sqlCommand", sqlCommand),

                };

                DataTable myTable = DataTableHelper.getTableData("spSearchAllForTrans", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable SearchInfoAR(string accountName, string accountNo, string folioNo, string isActive, string folioID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@AccountName", accountName),
                    new SqlParameter("@AccountNo", accountNo),
                    new SqlParameter("@FolioNo", folioNo),
                    new SqlParameter("@IsActive", isActive),
                    new SqlParameter("@FolioID", folioID),

                };

                DataTable myTable = DataTableHelper.getTableData("spARSearchInfo", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
        public DataTable AccountTypeData()
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                   

                };

                DataTable myTable = DataTableHelper.getTableData("spSearchARAccountType", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable AROpeningData()
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {


                };

                DataTable myTable = DataTableHelper.getTableData("spSearchAROldsBalances", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
        public DataTable ARTracesData()
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                     new SqlParameter("@ids", ""),

                };

                DataTable myTable = DataTableHelper.getTableData("spARSearchTrace", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
        public DataTable ARAccountReceivableSearch()
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                     new SqlParameter("@AccountName", ""),
                         new SqlParameter("@AccountNo", ""),
                             new SqlParameter("@AccountTypeID", ""),
                                 new SqlParameter("@Balance", ""),
                };

                DataTable myTable = DataTableHelper.getTableData("spARAccountReceivableSearch", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
