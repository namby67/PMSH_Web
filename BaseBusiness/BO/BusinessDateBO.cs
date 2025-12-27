using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;
namespace BaseBusiness.BO
{
    public class BusinessDateBO : BaseBO
    {
        private BusinessDateFacade facade = BusinessDateFacade.Instance;
        protected static BusinessDateBO instance = new BusinessDateBO();

        protected BusinessDateBO()
        {
            this.baseFacade = facade;
        }

        public static BusinessDateBO Instance
        {
            get { return instance; }
        }
    }
}
