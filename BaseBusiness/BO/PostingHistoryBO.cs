using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PostingHistoryBO : BaseBO
    {
        private PostingHistoryFacade facade = PostingHistoryFacade.Instance;
        protected static PostingHistoryBO instance = new PostingHistoryBO();

        protected PostingHistoryBO()
        {
            this.baseFacade = facade;
        }

        public static PostingHistoryBO Instance
        {
            get { return instance; }
        }
        public static List<PostingHistoryModel> GetPostingHistoryByFolio(int folio)
        {
            string query = $"select * from PostingHistory where AfterAction_FolioID = {folio}";
            return instance.GetList<PostingHistoryModel>(query);
        }
        public static List<PostingHistoryModel> GetPostingHistoryByInvoiceNo(int invoiceNo)
        {
            string query = $"select * from PostingHistory where InvoiceNo = '{invoiceNo}'";
            return instance.GetList<PostingHistoryModel>(query);
        }
    }
}
