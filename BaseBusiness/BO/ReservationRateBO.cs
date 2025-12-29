using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationRateBO : BaseBO
    {
        private ReservationRateFacade facade = ReservationRateFacade.Instance;
        protected static ReservationRateBO instance = new ReservationRateBO();

        protected ReservationRateBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationRateBO Instance
        {
            get { return instance; }
        }
    }
}
