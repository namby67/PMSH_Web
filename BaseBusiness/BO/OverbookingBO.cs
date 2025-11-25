using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class OverbookingBO : BaseBO
    {
        private OverbookingFacade facade = OverbookingFacade.Instance;
        protected static OverbookingBO instance = new OverbookingBO();

        protected OverbookingBO()
        {
            this.baseFacade = facade;
        }

        public static OverbookingBO Instance
        {
            get { return instance; }
        }
        public static int CheckOverBooking(int roomTypeID, DateTime date)
        {
            string query = $"select count(*) from Overbooking where RoomTypeID = {roomTypeID} and cast(Date as date) = cast('{date}' as date)";
            return instance.GetFirst<int>(query);
        }
    }
}
