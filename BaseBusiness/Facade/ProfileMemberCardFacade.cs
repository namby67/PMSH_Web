using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ProfileMemberCardFacade : BaseFacadeDB
    {
        protected static ProfileMemberCardFacade instance = new ProfileMemberCardFacade(new ProfileMemberCardModel());
        protected ProfileMemberCardFacade(ProfileMemberCardModel model) : base(model)
        {
        }
        public static ProfileMemberCardFacade Instance
        {
            get { return instance; }
        }
        protected ProfileMemberCardFacade() : base()
        {
        }
    }
}
