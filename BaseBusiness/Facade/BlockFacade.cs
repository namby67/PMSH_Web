using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class BlockFacade : BaseFacadeDB
    {
        protected static BlockFacade instance = new BlockFacade(new ArticleModel());
        protected BlockFacade(ArticleModel model) : base(model)
        {
        }
        public static BlockFacade Instance
        {
            get { return instance; }
        }
        protected BlockFacade() : base()
        {
        }
    }
}
