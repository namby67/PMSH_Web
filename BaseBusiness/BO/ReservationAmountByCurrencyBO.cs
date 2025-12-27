using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationAmountByCurrencyBO : BaseBO
    {
        private ReservationAmountByCurrencyFacade facade = ReservationAmountByCurrencyFacade.Instance;
        protected static ReservationAmountByCurrencyBO instance = new ReservationAmountByCurrencyBO();

        protected ReservationAmountByCurrencyBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationAmountByCurrencyBO Instance
        {
            get { return instance; }
        }
    }
}
