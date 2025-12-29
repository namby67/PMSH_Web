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
    public class ReservationAccompanyBO : BaseBO
    {
        private ReservationAccompanyFacade facade = ReservationAccompanyFacade.Instance;
        protected static ReservationAccompanyBO instance = new ReservationAccompanyBO();

        protected ReservationAccompanyBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationAccompanyBO Instance
        {
            get { return instance; }
        }
        public static List<object> GetReservationAccompanyByReservationID(int reservationID)
        {


            string query = $"SELECT \r\n    a.ID AS ID, \r\n    c.ID as ProfileID,\r\n    b.City, \r\n    c.Account, \r\n    CONVERT(varchar, c.DateOfBirth, 103) AS DateOfBirth\r\nFROM ReservationAccompany a\r\nLEFT JOIN Reservation b ON a.ReservationID = b.ID\r\nLEFT JOIN Profile c ON a.ProfileIndividualID = c.ID\r\nWHERE b.ID = {reservationID}\r\n";
            return instance.GetList<object>(query);
        }
        public static List<object> GetReservationAccompany(int reservationID, int profileID)
        {


            string query = $"select * from ReservationAccompany where ReservationID = {reservationID} and ProfileIndividualID = {profileID}";
            return instance.GetList<object>(query);
        }
    }
}
