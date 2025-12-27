using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PersonInChargeZoneFacade : BaseFacadeDB
    {
        protected static PersonInChargeZoneFacade instance = new PersonInChargeZoneFacade(new PersonInChargeZoneModel());
        protected PersonInChargeZoneFacade(PersonInChargeZoneModel model) : base(model)
        {
        }
        public static PersonInChargeZoneFacade Instance
        {
            get { return instance; }
        }
        protected PersonInChargeZoneFacade() : base()
        {
        }
    }
}
