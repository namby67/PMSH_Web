using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationTypeFacade : BaseFacadeDB
    {
        protected static ReservationTypeFacade instance = new ReservationTypeFacade(new ReservationTypeModel());
        protected ReservationTypeFacade(ReservationTypeModel model) : base(model)
        {
        }
        public static ReservationTypeFacade Instance
        {
            get { return instance; }
        }
        protected ReservationTypeFacade() : base()
        {
        }
    }
}
