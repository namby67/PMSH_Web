using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationSpecialFacade : BaseFacadeDB
    {
        protected static ReservationSpecialFacade instance = new ReservationSpecialFacade(new ReservationSpecialModel());
        protected ReservationSpecialFacade(ReservationSpecialModel model) : base(model)
        {
        }
        public static ReservationSpecialFacade Instance
        {
            get { return instance; }
        }
        protected ReservationSpecialFacade() : base()
        {
        }
    
    }
}
