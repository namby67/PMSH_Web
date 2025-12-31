using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationSpecialBO : BaseBO
    {
        private ReservationSpecialFacade facade = ReservationSpecialFacade.Instance;
        protected static ReservationSpecialBO instance = new ReservationSpecialBO();

        protected ReservationSpecialBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationSpecialBO Instance
        {
            get { return instance; }
        }
    }
}
