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
    public class ArticleService : IArticleService
    {
        public DataTable SearchArticle(string articleCode, string articleDescription, string articleSupplement, string transactionCode)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ArticleCode", articleCode),
                    new SqlParameter("@ArticleDescription", articleDescription),
                    new SqlParameter("@ArticleSupplement", articleSupplement),
                    new SqlParameter("@TransactionCode", transactionCode),
                };
                DataTable myTable = DataTableHelper.getTableData("spSearchArticle", param);
                return myTable;
            }
            catch (SqlException ex)
            {
                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
