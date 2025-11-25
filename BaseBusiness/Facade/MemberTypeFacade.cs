using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class MemberTypeFacade : BaseFacadeDB
    {
        protected static MemberTypeFacade instance = new MemberTypeFacade(new MemberTypeModel());
        protected MemberTypeFacade(MemberTypeModel model) : base(model)
        {
        }
        public static MemberTypeFacade Instance
        {
            get { return instance; }
        }
        protected MemberTypeFacade() : base()
        {
        }
    }
}
