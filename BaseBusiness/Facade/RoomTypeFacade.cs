using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class RoomTypeFacade : BaseFacadeDB
    {
        protected static RoomTypeFacade instance = new RoomTypeFacade(new RoomTypeModel());
        protected RoomTypeFacade(RoomTypeModel model) : base(model)
        {
        }
        public static RoomTypeFacade Instance
        {
            get { return instance; }
        }
        protected RoomTypeFacade() : base()
        {
        }
    }
}
