using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class RoomMoveFacade : BaseFacadeDB
    {
        protected static RoomMoveFacade instance = new RoomMoveFacade(new RoomMoveModel());
        protected RoomMoveFacade(RoomMoveModel model) : base(model)
        {
        }
        public static RoomMoveFacade Instance
        {
            get { return instance; }
        }
        protected RoomMoveFacade() : base()
        {
        }
    }
}
