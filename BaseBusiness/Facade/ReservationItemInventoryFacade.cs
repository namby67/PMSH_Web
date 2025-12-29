using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationItemInventoryFacade : BaseFacadeDB
    {
        protected static ReservationItemInventoryFacade instance = new ReservationItemInventoryFacade(new ReservationItemInventoryModel());
        protected ReservationItemInventoryFacade(ReservationItemInventoryModel model) : base(model)
        {
        }
        public static ReservationItemInventoryFacade Instance
        {
            get { return instance; }
        }
        protected ReservationItemInventoryFacade() : base()
        {
        }
    }
}
