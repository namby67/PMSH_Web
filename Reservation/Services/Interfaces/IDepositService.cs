using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Services.Interfaces
{
    public interface IDepositService
    {
        /// <summary>
        /// DatVP: Lây danh sách deposite request theo reservation id
        /// </summary>
        /// <param name="reservationID">id  reservation</param>
        /// <returns>Data table chứa danh sách deposit request</returns>
        DataTable SearchDepositRequest(int reservationID);

        /// <summary>
        /// DatVP: Lây danh sách deposite payment theo reservation id
        /// </summary>
        /// <param name="reservationID">id  reservation</param>
        /// <param name="depositRsqID">id  deposit request</param>

        /// <returns>Data table chứa danh sách deposit payment</returns>
        DataTable SearchDepositPayment(int reservationID,int depositRsqID);

    }
}
