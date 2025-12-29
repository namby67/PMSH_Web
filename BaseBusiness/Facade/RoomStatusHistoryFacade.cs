using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class RoomStatusHistoryFacade : BaseFacadeDB
    {
        protected static RoomStatusHistoryFacade instance = new RoomStatusHistoryFacade(new RoomStatusHistoryModel());
        protected RoomStatusHistoryFacade(RoomStatusHistoryModel model) : base(model)
        {
        }
        public static RoomStatusHistoryFacade Instance
        {
            get { return instance; }
        }
        protected RoomStatusHistoryFacade() : base()
        {
        }
    }
}
