using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationFixedChargeFacade : BaseFacadeDB
    {
        protected static ReservationFixedChargeFacade instance = new ReservationFixedChargeFacade(new ReservationFixedChargeModel());
        protected ReservationFixedChargeFacade(ReservationFixedChargeModel model) : base(model)
        {
        }
        public static ReservationFixedChargeFacade Instance
        {
            get { return instance; }
        }
        protected ReservationFixedChargeFacade() : base()
        {
        }
    }
}
