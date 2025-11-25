using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationFixedChargeBO : BaseBO
    {
        private ReservationFixedChargeFacade facade = ReservationFixedChargeFacade.Instance;
        protected static ReservationFixedChargeBO instance = new ReservationFixedChargeBO();

        protected ReservationFixedChargeBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationFixedChargeBO Instance
        {
            get { return instance; }
        }
    }
}
