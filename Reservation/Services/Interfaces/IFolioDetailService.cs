using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Services.Interfaces
{
    public interface IFolioDetailService
    {

        /// <summary>
        /// DatVP: get folio detail by folio
        /// </summary>
        /// <returns>Data table chứa danh sách folio detail</returns>
        DataTable GetFolioDetailByFolioID(int folioID, int mode);
    }
}
