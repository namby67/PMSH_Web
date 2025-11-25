using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Services.Interfaces
{
    public interface IInvoicingService
    {
        /// <summary>
        /// DatVP: Lây danh sách folio được assgin theo room No và tên đặt booking
        /// </summary>
        /// <param name="room">room no</param>
        /// <param name="name">tên đặt booking</param>

        /// <returns>Data table chứa danh sách folio theo room No và tên đặt booking</returns>
        DataTable SearchFolio(int guestStatus, int folioStatus,int folioType,string name,string room,string folioNo,string confirmationNo,string date);
    }
}
