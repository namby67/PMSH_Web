using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PersonInChargeBO : BaseBO
    {
        private PersonInChargeFacade facade = PersonInChargeFacade.Instance;
        protected static PersonInChargeBO instance = new PersonInChargeBO();

        protected PersonInChargeBO()
        {
            this.baseFacade = facade;
        }

        public static PersonInChargeBO Instance
        {
            get { return instance; }
        }
    }
}
