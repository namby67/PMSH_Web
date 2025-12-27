using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class RoomClassBO : BaseBO
    {
        private RoomClassFacade facade = RoomClassFacade.Instance;
        protected static RoomClassBO instance = new RoomClassBO();

        protected RoomClassBO()
        {
            this.baseFacade = facade;
        }

        public static RoomClassBO Instance
        {
            get { return instance; }
        }
    }
}
