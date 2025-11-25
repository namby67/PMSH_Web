using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class RoomTypeBO : BaseBO
    {
        private RoomTypeFacade facade = RoomTypeFacade.Instance;
        protected static RoomTypeBO instance = new RoomTypeBO();

        protected RoomTypeBO()
        {
            this.baseFacade = facade;
        }

        public static RoomTypeBO Instance
        {
            get { return instance; }
        }
    }
}
