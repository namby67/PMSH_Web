using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationAccompanyFacade : BaseFacadeDB
    {
        protected static ReservationAccompanyFacade instance = new ReservationAccompanyFacade(new ReservationAccompanyModel());
        protected ReservationAccompanyFacade(ReservationAccompanyModel model) : base(model)
        {
        }
        public static ReservationAccompanyFacade Instance
        {
            get { return instance; }
        }
        protected ReservationAccompanyFacade() : base()
        {
        }
    }
}
