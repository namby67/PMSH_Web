using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.BO;
using BaseBusiness.util;
using Cashiering.Services.Interfaces;
using Microsoft.Data.SqlClient;
namespace Cashiering.Services.Implements
{
    public class CashieringService : ICashieringService
    {
        public DataTable PostingJournal(
            string cashierNo,
            string transactionCodeList,
            string roomNoList,
            DateTime fromDate,
            DateTime toDate,
            string fromProfitCode,
            string toProfitCode,
            string groupID,
            string subgroupID)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CashierNo", cashierNo ?? ""),
                new SqlParameter("@TransactionCodeList", transactionCodeList ?? ""),
                new SqlParameter("@RoomNoList", roomNoList ?? ""),
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate),
                new SqlParameter("@FromProfitCode", fromProfitCode ),
                new SqlParameter("@ToProfitCode", toProfitCode),
                new SqlParameter("@GroupID", groupID ),
                new SqlParameter("@SubgroupID", subgroupID)
            };

            return DataTableHelper.getTableData("spSearchTransactionJournalByTotal", param);
        }
        public DataTable SearchTransactionJournalByNotVatInfor(
            string cashierNo,
            string transactionCodeList,
            string roomNoList,
            DateTime fromDate,
            DateTime toDate,
            string fromProfitCode,
            string toProfitCode,
            string groupID,
            string subgroupID)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CashierNo", cashierNo ?? ""),
                new SqlParameter("@TransactionCodeList", transactionCodeList ?? ""),
                new SqlParameter("@RoomNoList", roomNoList ?? ""),
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate),
                new SqlParameter("@FromProfitCode", fromProfitCode ),
                new SqlParameter("@ToProfitCode", toProfitCode),
                new SqlParameter("@GroupID", groupID ),
                new SqlParameter("@SubgroupID", subgroupID)
            };

            return DataTableHelper.getTableData("spSearchTransactionJournalByNotVatInfor", param);
        }
        public DataTable SearchTransactionJournalByVatInfor(
            string cashierNo,
            string transactionCodeList,
            string roomNoList,
            DateTime fromDate,
            DateTime toDate,
            string fromProfitCode,
            string toProfitCode,
            string groupID,
            string subgroupID)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CashierNo", cashierNo ?? ""),
                new SqlParameter("@TransactionCodeList", transactionCodeList ?? ""),
                new SqlParameter("@RoomNoList", roomNoList ?? ""),
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate),
                new SqlParameter("@FromProfitCode", fromProfitCode ),
                new SqlParameter("@ToProfitCode", toProfitCode),
                new SqlParameter("@GroupID", groupID ),
                new SqlParameter("@SubgroupID", subgroupID)
            };

            return DataTableHelper.getTableData("spSearchTransactionJournalByVatInfor", param);
        }
        public DataTable CashierAudit(string userName, DateTime fromDate, DateTime toDate, string shiftID)
        {
            SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@UserName", userName ?? ""),
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate),
                new SqlParameter("@ShiftID", shiftID ?? "")
                };

            return DataTableHelper.getTableData("spSearchShift", param);
        }
        public DataTable ShiftDetail(int shiftID, int type)
        {
            SqlParameter[] param = new SqlParameter[]
               {
                new SqlParameter("@ShiftID", shiftID),
                new SqlParameter("@Type", type)

               };

            return DataTableHelper.getTableData("spSearchTransactionCloseShift_New", param);
        }
        public DataTable ExchangeRate()
        {
            SqlParameter[] param = new SqlParameter[] { }; // không có tham số

            return DataTableHelper.getTableData("spSearchAllForTrans", new SqlParameter[]
            {
            new SqlParameter("@sqlCommand", @"
            SELECT a.ID, a.DateTime, a.FromCurrencyID, a.ToCurrencyID,
                   a.ExChangeRate AS BuyRate, a.ExchangeRateSell AS SellRate,
                   a.ExChangeRateMin, a.DenominationMax, a.ExChangeRateMax,
                   a.ExChangeRateMedium, a.DenominationMedium, a.DenominationMin,
                   b.LoginName AS CreateBy, c.LoginName AS UpdateBy,
                   a.CreateDate, a.UpdateDate
            FROM ExchangeRate a
            LEFT JOIN Users b ON a.UserInsertID = b.ID
            LEFT JOIN Users c ON a.UserUpdateID = c.ID
            ORDER BY a.DateTime DESC
        ")
            });
        }
        public DataTable ExchangeCurrency(string account, string passPort, string roomNo, DateTime fromDate, DateTime toDate, int isDelete)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Account", account ?? ""),
                new SqlParameter("@PassPort", passPort ?? ""),
                new SqlParameter("@RoomNo", roomNo ?? ""),
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate),
                new SqlParameter("@IsDelete", isDelete)
            };
            return DataTableHelper.getTableData("spExchangeCurrencySearch", param);

        }
        public DataTable FolioHistoryView(DateTime fromDate, DateTime toDate, string fromFolioID, string toFolioID, string fromRoom, string toRoom, string actionType, string user)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@FromDate", fromDate.ToString("yyyy-MM-dd")),
                new SqlParameter("@ToDate", toDate.ToString("yyyy-MM-dd")),
                new SqlParameter("@FromFolioID", fromFolioID ?? ""),
                new SqlParameter("@ToFolioID", toFolioID ?? ""),
                new SqlParameter("@FromRoom", fromRoom ?? ""),
                new SqlParameter("@ToRoom", toRoom ?? ""),
                new SqlParameter("@ActionType", actionType ?? ""),
                new SqlParameter("@User", user ?? "")
            };

            DataTable myTable = DataTableHelper.getTableData("spSearchPostingHistoryGeneral", param);
            return myTable;
        }
        public DataTable SearchPostingHistoryDetail(string invoiceNo)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@InvoiceNo", invoiceNo )
            };

            DataTable myTable = DataTableHelper.getTableData("spSearchPostingHistoryDetail", param);
            return myTable;
        }
        public DataTable CashierReport(int shiftID, int mode)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ShiftID", shiftID ),
                new SqlParameter("@Mode", mode ),
            };

            DataTable myTable = DataTableHelper.getTableData("spCashierReport", param);
            return myTable;
        }

        public DataTable ExchangeCurrencyReportData(DateTime fromDate, string cachier, string zonecode)
        {
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@TransactionDate", fromDate),
               new SqlParameter("@ShiftID", cachier),
                  new SqlParameter("@Zone", zonecode)

            };

            DataTable myTable = DataTableHelper.getTableData("spRptExchangeCurrencyByCashier", param);
            return myTable;
        }

        public DataTable ExchangeCurrencyPrint( string id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@ID", id),


            };

            DataTable myTable = DataTableHelper.getTableData("spRptExchangeCurrencyReceipt", param);
            return myTable;
        }
    } 
}
