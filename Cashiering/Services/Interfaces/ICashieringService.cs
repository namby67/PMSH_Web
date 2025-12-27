using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.BO;
namespace Cashiering.Services.Interfaces
{
    public interface ICashieringService
    {
     public  DataTable PostingJournal(
            string cashierNo,
            string transactionCodeList,
            string roomNoList,
            DateTime fromDate,
            DateTime toDate,
            string fromProfitCode,
            string toProfitCode,
            string groupID,
            string subgroupID);
 
        public DataTable SearchTransactionJournalByNotVatInfor(
            string cashierNo,
            string transactionCodeList,
            string roomNoList,
            DateTime fromDate,
            DateTime toDate,
            string fromProfitCode,
            string toProfitCode,
            string groupID,
            string subgroupID);
        public DataTable SearchTransactionJournalByVatInfor(
           string cashierNo,
           string transactionCodeList,
           string roomNoList,
           DateTime fromDate,
           DateTime toDate,
           string fromProfitCode,
           string toProfitCode,
           string groupID,
           string subgroupID);
        public DataTable CashierAudit(string userName, DateTime fromDate, DateTime toDate, string shiftID);
      
        public DataTable ShiftDetail(int shiftID, int type);
        public DataTable ExchangeRate();
        public DataTable ExchangeCurrency(string account, string passPort, string roomNo, DateTime fromDate, DateTime toDate, int isDelete);
        public DataTable FolioHistoryView(DateTime fromDate, DateTime toDate, string fromFolioID, string toFolioID, string fromRoom, string toRoom, string actionType, string user);
        public DataTable SearchPostingHistoryDetail(string invoiceNo);

        public DataTable CashierReport(int shiftID, int mode);

        DataTable ExchangeCurrencyReportData(DateTime fromDate, string cachier, string zonecode);
        DataTable ExchangeCurrencyPrint(string id);
    }
}

