using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationAlertsFacade : BaseFacadeDB
    {
        protected static ReservationAlertsFacade instance = new ReservationAlertsFacade(new ReservationAlertsModel());
        protected ReservationAlertsFacade(ReservationAlertsModel model) : base(model)
        {
        }
        public static ReservationAlertsFacade Instance
        {
            get { return instance; }
        }
        protected ReservationAlertsFacade() : base()
        {
        }
    }
}
