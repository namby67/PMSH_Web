using System.Data;
using Microsoft.Data.SqlClient;
using BaseBusiness.util;
using Administration.Services.Interfaces;
using System.Text;
using Newtonsoft.Json;
using static Administration.DTO.DevExtremeDTO;
using BaseBusiness.Model;
using BaseBusiness.BO;
using System.Collections;

namespace Administration.Services.Implements
{
    public class TransactionArticleLinkService : ITransactionArticleLinkService
    {
        public DataTable SearchTypeData(
            string? transCode,
            string? articleCode,
            string? transDes,
            string? articleDes,
            string? sort,
            string? group,
            int skip,
            int take
        )
        {
            var sql = new StringBuilder(@"
                SELECT  
                    a.ID,
                    b.Code  AS Infor,
                    b.Code AS TransactionCode,
                    b.Description AS TransactionDescription,
                    c.Code AS ArticleCode,
                    c.Description AS ArticleDescription
                FROM TransactionArticleLnk a
                JOIN Transactions b ON a.TransactionCode = b.Code
                JOIN Article c ON a.ArticleCode = c.Code
                WHERE 1 = 1
            ");

            // ===== FILTER =====
            if (!string.IsNullOrWhiteSpace(transCode))
                sql.Append($" AND b.Code LIKE N'%{transCode}%' ");

            if (!string.IsNullOrWhiteSpace(transDes))
                sql.Append($" AND b.Description LIKE N'%{transDes}%' ");

            if (!string.IsNullOrWhiteSpace(articleCode))
                sql.Append($" AND c.Code LIKE N'%{articleCode}%' ");

            if (!string.IsNullOrWhiteSpace(articleDes))
                sql.Append($" AND c.Description LIKE N'%{articleDes}%' ");

            // ===== ORDER BY =====
            string orderBy = " ORDER BY b.Code ";

            // 🔹 Ưu tiên GROUP
            if (!string.IsNullOrEmpty(group))
            {
                var groupInfo = JsonConvert.DeserializeObject<List<DevExtremeGroup>>(group);
                if (groupInfo?.Count > 0 &&
                    SortMap.TryGetValue(groupInfo[0].Selector, out var col))
                {
                    orderBy = $" ORDER BY {col} {(groupInfo[0].Desc ? "DESC" : "ASC")} ";
                }
            }
            // 🔹 Nếu không group → dùng sort
            else if (!string.IsNullOrEmpty(sort))
            {
                var sortInfo = JsonConvert.DeserializeObject<List<DevExtremeSort>>(sort);
                if (sortInfo?.Count > 0 &&
                    SortMap.TryGetValue(sortInfo[0].Selector, out var col))
                {
                    orderBy = $" ORDER BY {col} {(sortInfo[0].Desc ? "DESC" : "ASC")} ";
                }
            }

            sql.Append(orderBy);

            // ===== PAGING =====
            sql.Append($@"
        OFFSET {skip} ROWS
        FETCH NEXT {take} ROWS ONLY
    ");

            return TextUtils.Select(sql.ToString());
        }


        public int InsertTAL(List<string> transactionIds, List<string> articleIds)
        {
            int count = 0;

            foreach (var transactionCode in transactionIds)
            {
                foreach (var articleCode in articleIds)
                {
                    try
                    {
                        if (Exists(transactionCode, articleCode))
                            continue; // bỏ qua nếu trùng
                        var link = new TransactionArticleLnkModel
                        {
                            TransactionCode = transactionCode,
                            ArticleCode = articleCode
                        };

                        TransactionArticleLnkBO.Instance.Insert(link);
                        count++;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return count;
        }
        public int UpdateTAL(int ID, string TransactionEdit, string ArticleEdit)
        {
            try
            {
                TransactionArticleLnkModel entity;
                var businessDate = PropertyUtils
                    .ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll())![0]
                    .BusinessDate;

                entity = new TransactionArticleLnkModel
                {
                    ID = ID,
                    TransactionCode = TransactionEdit,
                    ArticleCode = ArticleEdit
                };
                TransactionArticleLnkBO.Instance.Update(entity);
                return entity.ID;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Tách funtion

        private static readonly Dictionary<string, string> SortMap = new()
        {
            { "transactionCode", "b.Code" },
            { "transactionDescription", "b.Description" },
            { "articleCode", "c.Code" },
            { "articleDescription", "c.Description" }
        };
        public static bool Exists(string transactionCode, string articleCode)
        {
            var exp = new Expression("TransactionCode", transactionCode)
                            .And("ArticleCode", articleCode);

            ArrayList result = TransactionArticleLnkBO.Instance.FindByExpression(1, exp);

            return result != null && result.Count > 0;
        }


    }
}
