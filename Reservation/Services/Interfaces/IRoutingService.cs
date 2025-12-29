using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Services.Interfaces
{
    public interface IRoutingService
    {
        /// <summary>
        /// DatVP: Lây danh sách routing theo reservation id
        /// </summary>
        /// <param name="reservationID">id  reservation</param>
        /// <param name="confirmationNo">confirmation No</param>
        /// <returns>Data table chứa danh sách reouting theo reservation id</returns>
        DataTable SearchRouting(string reservationID, string confirmationNo);


        DataTable SearchAllForTrans(string sqlCommand);



    }
}
