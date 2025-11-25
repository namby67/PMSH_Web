using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashiering.Services.Interfaces
{
    public interface IFolioVATSearchService
    {
        /// <summary>
        /// DatVP: tìm kiếm folio vat
        /// </summary>


        /// <returns>Data table chứa danh sách folio vat</returns>
        DataTable SearchFolioVAT(DateTime fromDate, DateTime toDate, int folioStatus,int printStatus,int type);
    }
}
