using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class CommentFacade: BaseFacadeDB
    {
        protected static CommentFacade instance = new CommentFacade(new CommentModel());
        protected CommentFacade(CommentModel model) : base(model)
        {
        }
        public static CommentFacade Instance
        {
            get { return instance; }
        }
        protected CommentFacade() : base()
        {
        }
    }
}
