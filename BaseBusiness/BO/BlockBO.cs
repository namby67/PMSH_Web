using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class BlockBO : BaseBO
    {
        private BlockFacade facade = BlockFacade.Instance;
        protected static BlockBO instance = new BlockBO();

        protected BlockBO()
        {
            this.baseFacade = facade;
        }

        public static BlockBO Instance
        {
            get { return instance; }
        }
    }
}
