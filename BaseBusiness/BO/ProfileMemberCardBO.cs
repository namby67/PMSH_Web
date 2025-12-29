using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ProfileMemberCardBO : BaseBO
    {
        private ProfileMemberCardFacade facade = ProfileMemberCardFacade.Instance;
        protected static ProfileMemberCardBO instance = new ProfileMemberCardBO();

        protected ProfileMemberCardBO()
        {
            this.baseFacade = facade;
        }

        public static ProfileMemberCardBO Instance
        {
            get { return instance; }
        }
    }
}
