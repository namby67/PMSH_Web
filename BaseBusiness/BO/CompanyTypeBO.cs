using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class CompanyTypeBO : BaseBO
    {
        private CompanyTypeFacade facade = CompanyTypeFacade.Instance;
        protected static CompanyTypeBO instance = new CompanyTypeBO();

        protected CompanyTypeBO()
        {
            this.baseFacade = facade;
        }

        public static CompanyTypeBO Instance
        {
            get { return instance; }
        }
    }
}
