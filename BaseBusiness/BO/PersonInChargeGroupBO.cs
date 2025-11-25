using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PersonInChargeGroupBO : BaseBO
    {
        private PersonInChargeGroupFacade facade = PersonInChargeGroupFacade.Instance;
        protected static PersonInChargeGroupBO instance = new PersonInChargeGroupBO();

        protected PersonInChargeGroupBO()
        {
            this.baseFacade = facade;
        }

        public static PersonInChargeGroupBO Instance
        {
            get { return instance; }
        }
    }
}
