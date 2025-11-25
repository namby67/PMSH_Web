using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class MemberCategoryFacade : BaseFacadeDB
    {
        protected static MemberCategoryFacade instance = new MemberCategoryFacade(new MemberCategoryModel());
        protected MemberCategoryFacade(MemberCategoryModel model) : base(model)
        {
        }
        public static MemberCategoryFacade Instance
        {
            get { return instance; }
        }
        protected MemberCategoryFacade() : base()
        {
        }
    }
}
