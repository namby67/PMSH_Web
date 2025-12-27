using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class RoomMoveBO : BaseBO
    {
        private RoomMoveFacade facade = RoomMoveFacade.Instance;
        protected static RoomMoveBO instance = new RoomMoveBO();

        protected RoomMoveBO()
        {
            this.baseFacade = facade;
        }

        public static RoomMoveBO Instance
        {
            get { return instance; }
        }
    }
}
