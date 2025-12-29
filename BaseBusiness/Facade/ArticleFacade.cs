using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ArticleFacade : BaseFacadeDB
    {
        protected static ArticleFacade instance = new ArticleFacade(new ArticleModel());
        protected ArticleFacade(ArticleModel model) : base(model)
        {
        }
        public static ArticleFacade Instance
        {
            get { return instance; }
        }
        protected ArticleFacade() : base()
        {
        }
    }
}
