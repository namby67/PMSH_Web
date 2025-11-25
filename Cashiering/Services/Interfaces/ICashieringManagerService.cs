using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashiering.Services.Interfaces
{
    public interface ICashieringManagerService
    {
        /// <summary>
        /// DatVP: Lây danh sách guest in house
        /// </summary>

        /// <returns>Data table chứa danh sách guest in house</returns>
        DataTable GetGUestInHouse(string room,string name,string block,string group,string party,string company,string confirmationNo,DateTime arrivalDate, DateTime arrivalTo,DateTime departure,string crsNo,string package, string guestName,int zone,int typeSearch);
    }
}
