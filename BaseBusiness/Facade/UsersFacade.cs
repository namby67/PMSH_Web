using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class UsersFacade : BaseFacadeDB
    {
        protected static UsersFacade instance = new UsersFacade(new UsersModel());
        protected UsersFacade(UsersModel model) : base(model)
        {
        }
        public static UsersFacade Instance
        {
            get { return instance; }
        }
        protected UsersFacade() : base()
        {
        }
    }
}
