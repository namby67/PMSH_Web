using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationCancellationBO : BaseBO
    {
        private ReservationCancellationFacade facade = ReservationCancellationFacade.Instance;
        protected static ReservationCancellationBO instance = new ReservationCancellationBO();

        protected ReservationCancellationBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationCancellationBO Instance
        {
            get { return instance; }
        }
        public static string GetTopCancellatioNo()
        {
            string query = "select top 1 CancellationNo from ReservationCancellation order by id desc";
            return instance.GetFirst<string>(query);
        }
    }
}
