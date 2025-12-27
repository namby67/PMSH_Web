using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationRateFacade : BaseFacadeDB
    {
        protected static ReservationRateFacade instance = new ReservationRateFacade(new ReservationRateModel());
        protected ReservationRateFacade(ReservationRateModel model) : base(model)
        {
        }
        public static ReservationRateFacade Instance
        {
            get { return instance; }
        }
        protected ReservationRateFacade() : base()
        {
        }
    }
}
