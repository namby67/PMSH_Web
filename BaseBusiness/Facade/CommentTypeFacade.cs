using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class CommentTypeFacade : BaseFacadeDB
    {
        protected static CommentTypeFacade instance = new CommentTypeFacade(new CommentTypeModel());
        protected CommentTypeFacade(CommentTypeModel model) : base(model)
        {
        }
        public static CommentTypeFacade Instance
        {
            get { return instance; }
        }
        protected CommentTypeFacade() : base()
        {
        }
    
    }
}
