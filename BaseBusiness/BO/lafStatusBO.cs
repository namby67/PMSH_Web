using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class lafStatusBO : BaseBO
    {
        private lafStatusFacade facade = lafStatusFacade.Instance;
        protected static lafStatusBO instance = new lafStatusBO();

        protected lafStatusBO()
        {
            this.baseFacade = facade;
        }

        public static lafStatusBO Instance
        {
            get { return instance; }
        }
    }
}
