using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class RoomFacade : BaseFacadeDB
    {
        protected static RoomFacade instance = new RoomFacade(new RoomModel());
        protected RoomFacade(RoomModel model) : base(model)
        {
        }
        public static RoomFacade Instance
        {
            get { return instance; }
        }
        protected RoomFacade() : base()
        {
        }
    }
}
