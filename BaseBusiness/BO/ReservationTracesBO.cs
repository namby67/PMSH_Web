using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationTracesBO : BaseBO
    {
        private ReservationTracesFacade facade = ReservationTracesFacade.Instance;
        protected static ReservationTracesBO instance = new ReservationTracesBO();

        protected ReservationTracesBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationTracesBO Instance
        {
            get { return instance; }
        }
    }
}
