using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashiering.Services.Interfaces
{
    public interface ICloseShiftService 
    {
        /// <summary>
        /// DatVP: Lây danh sách payment, excharge theo shift id
        /// </summary>
        /// <param name="shiftID">id shift</param>
        /// <param name="type">type </param>

        /// <returns>Data table chứa danh sách folio theo room No và tên đặt booking</returns>
        DataTable GetCloseShift(int shiftID, int type);
    }
}
