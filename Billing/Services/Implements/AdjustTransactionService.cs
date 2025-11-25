using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Billing.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Billing.Services.Implements
{
    public class AdjustTransactionService : IAdjustTransactionService
    {
        public List<CommentModel> GetReasonAdjust()
        {
            try
            {

                return CommentBO.GetReasonAdjust();
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
