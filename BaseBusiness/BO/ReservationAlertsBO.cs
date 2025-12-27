using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationAlertsBO : BaseBO
    {
        private ReservationAlertsFacade facade = ReservationAlertsFacade.Instance;
        protected static ReservationAlertsBO instance = new ReservationAlertsBO();

        protected ReservationAlertsBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationAlertsBO Instance
        {
            get { return instance; }
        }
    }
}
