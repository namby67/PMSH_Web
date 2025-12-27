using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationTracesFacade : BaseFacadeDB
    {
        protected static ReservationTracesFacade instance = new ReservationTracesFacade(new ReservationTracesModel());
        protected ReservationTracesFacade(ReservationTracesModel model) : base(model)
        {
        }
        public static ReservationTracesFacade Instance
        {
            get { return instance; }
        }
        protected ReservationTracesFacade() : base()
        {
        }
    }
}
