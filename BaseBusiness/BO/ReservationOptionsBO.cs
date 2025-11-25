using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationOptionsBO : BaseBO
    {
        private ReservationOptionsFacade facade = ReservationOptionsFacade.Instance;
        protected static ReservationOptionsBO instance = new ReservationOptionsBO();

        protected ReservationOptionsBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationOptionsBO Instance
        {
            get { return instance; }
        }
    }
}
