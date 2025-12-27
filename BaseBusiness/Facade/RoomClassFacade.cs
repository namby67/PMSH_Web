using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class RoomClassFacade : BaseFacadeDB
    {
        protected static RoomClassFacade instance = new RoomClassFacade(new RoomClassModel());
        protected RoomClassFacade(RoomClassModel model) : base(model)
        {
        }
        public static RoomClassFacade Instance
        {
            get { return instance; }
        }
        protected RoomClassFacade() : base()
        {
        }
    }
}
