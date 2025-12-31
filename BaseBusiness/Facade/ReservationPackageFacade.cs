using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ReservationPackageFacade : BaseFacadeDB
    {
        protected static ReservationPackageFacade instance = new ReservationPackageFacade(new ReservationPackageModel());
        protected ReservationPackageFacade(ReservationPackageModel model) : base(model)
        {
        }
        public static ReservationPackageFacade Instance
        {
            get { return instance; }
        }
        protected ReservationPackageFacade() : base()
        {
        }
    }
}
