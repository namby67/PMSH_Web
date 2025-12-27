using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class lafLostAndFoundBO : BaseBO
    {
        private lafLostAndFoundFacade facade = lafLostAndFoundFacade.Instance;
        protected static lafLostAndFoundBO instance = new lafLostAndFoundBO();

        protected lafLostAndFoundBO()
        {
            this.baseFacade = facade;
        }

        public static lafLostAndFoundBO Instance
        {
            get { return instance; }
        }
    }
}
