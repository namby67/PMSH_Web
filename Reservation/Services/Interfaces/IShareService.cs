using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Services.Interfaces
{
    public interface IShareService
    {
        /// <summary>
        /// DatVP: Lây danh sách share rate detail
        /// </summary>
        /// <param name="reservationID">id  reservation</param>
        /// <returns>Data table chứa danh sách share rate detail</returns>
        DataTable ShareRateDetail(int reservationID);



        /// <summary>
        /// DatVP: Lây danh sách share room detail
        /// </summary>
        /// <param name="reservationID">id  reservation</param>
        /// <returns>Data table chứa danh sách  share room detail</returns>
        DataTable ShareRoomDetail(int reservationID);


        /// <summary>
        /// DatVP: Lây danh sách share reservation detail
        /// </summary>
        /// <param name="reservationID">id  reservation</param>
        /// <param name="shareNo">confirmation No</param>
        /// <returns>Data table chứa danh sách share reservation detail</returns>
        DataTable ShareReservationDetail(int reservationID, int shareNo);
    }
}
