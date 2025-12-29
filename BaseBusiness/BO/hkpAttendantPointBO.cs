using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class hkpAttendantPointBO : BaseBO
    {
        private hkpAttendantPointFacade facade = hkpAttendantPointFacade.Instance;
        protected static hkpAttendantPointBO instance = new hkpAttendantPointBO();

        protected hkpAttendantPointBO()
        {
            this.baseFacade = facade;
        }

        public static hkpAttendantPointBO Instance
        {
            get { return instance; }
        }
        public static List<hkpAttendantPointModel> GethkpAttendantPoint(DateTime fromDate, DateTime toDate, string attendant)
        {
            string query = "SELECT * FROM hkpAttendantPoint WHERE 1=1";

            if (fromDate > DateTime.MinValue && toDate > DateTime.MinValue)
            {
                query += $@"
            AND DATEDIFF(DAY, AttendantDate, '{fromDate}') <= 0 
            AND DATEDIFF(DAY, AttendantDate, '{toDate}') >= 0";
            }

            if (!string.IsNullOrWhiteSpace(attendant))
            {
                query += $" AND AttendantID IN ({attendant})";
            }

            return instance.GetList<hkpAttendantPointModel>(query);
        }


    }
}
