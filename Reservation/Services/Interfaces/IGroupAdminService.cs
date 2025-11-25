using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Services.Interfaces
{
    public interface IGroupAdminService
    {
        DataTable SearchGroupCheckInRoom(string ConfirmationNo, string Inspected,string Clean,string AllRooms,string CleanAndInspected);

        DataTable spReservationSearchByConfirmationNo(string ConfirmationNo);

    }
}
