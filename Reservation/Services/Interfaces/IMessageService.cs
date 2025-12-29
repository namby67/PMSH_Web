using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Services.Interfaces
{
    public interface IMessageService
    {

        /// <summary>
        /// DatVP: Lây danh sách message
        /// </summary>
        /// <returns>Data table chứa danh sách message</returns>
        DataTable SearchMessage(string Name,string ReservationHolder,string ConfirmationNo,string CRSNo,string RoomNo,string Zone,string Status,string Receive,string Print);

    }
}
