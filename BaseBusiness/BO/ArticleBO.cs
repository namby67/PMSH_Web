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
    public class ArticleBO : BaseBO
    {
        private ArticleFacade facade = ArticleFacade.Instance;
        protected static ArticleBO instance = new ArticleBO();

        protected ArticleBO()
        {
            this.baseFacade = facade;
        }

        public static ArticleBO Instance
        {
            get { return instance; }
        }
        public static List<ArticleModel> GetList()
        {

            string query = $"select * from Article where IsActive = 1 ";
            return instance.GetList<ArticleModel>(query);
        }
    }
}
