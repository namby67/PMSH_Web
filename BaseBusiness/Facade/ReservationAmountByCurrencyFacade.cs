using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationAmountByCurrencyFacade : BaseFacadeDB
    {
        protected static ReservationAmountByCurrencyFacade instance = new ReservationAmountByCurrencyFacade(new ReservationAmountByCurrencyModel());
        protected ReservationAmountByCurrencyFacade(ReservationAmountByCurrencyModel model) : base(model)
        {
        }
        public static ReservationAmountByCurrencyFacade Instance
        {
            get { return instance; }
        }
        protected ReservationAmountByCurrencyFacade() : base()
        {
        }
    }
}
