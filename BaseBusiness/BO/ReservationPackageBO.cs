using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationPackageBO : BaseBO
    {
        private ReservationPackageFacade facade = ReservationPackageFacade.Instance;
        protected static ReservationPackageBO instance = new ReservationPackageBO();

        protected ReservationPackageBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationPackageBO Instance
        {
            get { return instance; }
        }
    }
}
