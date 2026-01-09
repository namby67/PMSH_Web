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
        public static List<hkpAttendantPointModel> GethkpAttendantPoint(
          DateTime fromDate,
          DateTime toDate,
          string attendant)
        {
            string query = "SELECT * FROM hkpAttendantPoint WHERE 1=1";

            if (fromDate > DateTime.MinValue && toDate > DateTime.MinValue)
            {
                string from = fromDate.ToString("yyyy/MM/dd");
                string to = toDate.AddDays(1).ToString("yyyy/MM/dd");

                query += $@"
            AND AttendantDate >= '{from}'
            AND AttendantDate <  '{to}'";
            }

            if (!string.IsNullOrWhiteSpace(attendant))
            {
                query += $" AND AttendantID IN ({attendant})";
            }

            return instance.GetList<hkpAttendantPointModel>(query);
        }



    }
}
