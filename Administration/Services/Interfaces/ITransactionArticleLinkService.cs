using System.Data;

namespace Administration.Services.Interfaces
{
    public interface ITransactionArticleLinkService
    {
        // lấy danh sách cho DataGrid
        DataTable SearchTypeData(
            string? transCode,
            string? articleCode,
            string? transDes,
            string? articleDes,
            string? sort,
            string? group,
            int skip,
            int take
        );
        int InsertTAL(List<string> transactionIds, List<string> articleIds);
        int UpdateTAL(int ID, string TransactionEdit, string ArticleEdit);
    }
}
