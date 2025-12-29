using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class UsersBO : BaseBO
    {
        private UsersFacade facade = UsersFacade.Instance;
        protected static UsersBO instance = new UsersBO();

        protected UsersBO()
        {
            this.baseFacade = facade;
        }

        public static UsersBO Instance
        {
            get { return instance; }
        }
    }
}
