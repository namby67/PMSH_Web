using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PersonInChargeGroupFacade : BaseFacadeDB
    {
        protected static PersonInChargeGroupFacade instance = new PersonInChargeGroupFacade(new PersonInChargeGroupModel());
        protected PersonInChargeGroupFacade(PersonInChargeGroupModel model) : base(model)
        {
        }
        public static PersonInChargeGroupFacade Instance
        {
            get { return instance; }
        }
        protected PersonInChargeGroupFacade() : base()
        {
        }
    }
}
