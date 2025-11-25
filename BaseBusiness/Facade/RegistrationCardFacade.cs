using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class RegistrationCardFacade : BaseFacadeDB
    {
        protected static RegistrationCardFacade instance = new RegistrationCardFacade(new RegistrationCardModel());
        protected RegistrationCardFacade(RegistrationCardModel model) : base(model)
        {
        }
        public static RegistrationCardFacade Instance
        {
            get { return instance; }
        }
        protected RegistrationCardFacade() : base()
        {
        }
    }
}
