using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationFacade : BaseFacadeDB
    {
        protected static ReservationFacade instance = new ReservationFacade(new ReservationModel());
        protected ReservationFacade(ReservationModel model) : base(model)
        {
        }
        public static ReservationFacade Instance
        {
            get { return instance; }
        }
        protected ReservationFacade() : base()
        {
        }
    }
}
