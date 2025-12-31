using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationOptionsFacade : BaseFacadeDB
    {
        protected static ReservationOptionsFacade instance = new ReservationOptionsFacade(new ReservationOptionsModel());
        protected ReservationOptionsFacade(ReservationOptionsModel model) : base(model)
        {
        }
        public static ReservationOptionsFacade Instance
        {
            get { return instance; }
        }
        protected ReservationOptionsFacade() : base()
        {
        }
    }
}
