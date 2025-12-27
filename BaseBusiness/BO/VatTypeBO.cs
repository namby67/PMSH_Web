using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public  class VatTypeBO : BaseBO
    {
        private VatTypeFacade facade = VatTypeFacade.Instance;
        protected static VatTypeBO instance = new VatTypeBO();

        protected VatTypeBO()
        {
            this.baseFacade = facade;
        }

        public static VatTypeBO Instance
        {
            get { return instance; }
        }
    }
}
