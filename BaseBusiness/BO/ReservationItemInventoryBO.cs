using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationItemInventoryBO : BaseBO
    {
        private ReservationItemInventoryFacade facade = ReservationItemInventoryFacade.Instance;
        protected static ReservationItemInventoryBO instance = new ReservationItemInventoryBO();

        protected ReservationItemInventoryBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationItemInventoryBO Instance
        {
            get { return instance; }
        }
    }
}
