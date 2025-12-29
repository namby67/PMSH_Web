using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PersonInChargeFacade : BaseFacadeDB
    {
        protected static PersonInChargeFacade instance = new PersonInChargeFacade(new PersonInChargeModel());
        protected PersonInChargeFacade(PersonInChargeModel model) : base(model)
        {
        }
        public static PersonInChargeFacade Instance
        {
            get { return instance; }
        }
        protected PersonInChargeFacade() : base()
        {
        }
    }
}
