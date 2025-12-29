using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PostingHistoryFacade : BaseFacadeDB
    {
        protected static PostingHistoryFacade instance = new PostingHistoryFacade(new PostingHistoryModel());
        protected PostingHistoryFacade(PostingHistoryModel model) : base(model)
        {
        }
        public static PostingHistoryFacade Instance
        {
            get { return instance; }
        }
        protected PostingHistoryFacade() : base()
        {
        }
    }
}
