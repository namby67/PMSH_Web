using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationCancellationFacade : BaseFacadeDB
    {
        protected static ReservationCancellationFacade instance = new ReservationCancellationFacade(new ReservationCancellationModel());
        protected ReservationCancellationFacade(ReservationCancellationModel model) : base(model)
        {
        }
        public static ReservationCancellationFacade Instance
        {
            get { return instance; }
        }
        protected ReservationCancellationFacade() : base()
        {
        }
    }
}
