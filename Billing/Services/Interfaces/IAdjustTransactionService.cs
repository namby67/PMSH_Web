using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Services.Interfaces
{
    public interface IAdjustTransactionService
    {

        /// <summary>
        /// DatVP: Lấy danh sách reason adjust transaction
        /// </summary>
    
        /// <returns>Danh sách reason adjustment transaction</returns>
        List<CommentModel> GetReasonAdjust();
    }
}
