using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ItemBO : BaseBO
    {
        private ItemFacade facade = ItemFacade.Instance;
        protected static ItemBO instance = new ItemBO();

        protected ItemBO()
        {
            this.baseFacade = facade;
        }

        public static ItemBO Instance
        {
            get { return instance; }
        }
    }
}
