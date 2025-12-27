using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class CompanyTypeFacade : BaseFacadeDB
    {
        protected static CompanyTypeFacade instance = new CompanyTypeFacade(new CompanyTypeModel());
        protected CompanyTypeFacade(CompanyTypeModel model) : base(model)
        {
        }
        public static CompanyTypeFacade Instance
        {
            get { return instance; }
        }
        protected CompanyTypeFacade() : base()
        {
        }
    }
}
