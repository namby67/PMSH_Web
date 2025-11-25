using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Services.Interfaces
{
    public interface IArticleService
    {
        public DataTable SearchArticle(string articleCode,string articleDescription,string articleSupplement,string transactionCode);
    }
}
