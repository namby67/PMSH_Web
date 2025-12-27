using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ProfileFacade : BaseFacadeDB
    {
        protected static ProfileFacade instance = new ProfileFacade(new ProfileModel());
        protected ProfileFacade(ProfileModel model) : base(model)
        {
        }
        public static ProfileFacade Instance
        {
            get { return instance; }
        }
        protected ProfileFacade() : base()
        {
        }
    }
}
