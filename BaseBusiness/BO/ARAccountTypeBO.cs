using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ARAccountTypeBO : BaseBO
    {
        private ARAccountTypeFacade facade = ARAccountTypeFacade.Instance;
        protected static ARAccountTypeBO instance = new ARAccountTypeBO();

        protected ARAccountTypeBO()
        {
            this.baseFacade = facade;
        }

        public static ARAccountTypeBO Instance
        {
            get { return instance; }
        }
    }
}
