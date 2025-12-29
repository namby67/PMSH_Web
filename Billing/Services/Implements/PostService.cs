using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Billing.Services.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Services.Implements
{
    public class PostService : IPostService
    {
        public decimal CalculateNet(string transactionCode, decimal price)
        {
            try
            {
                decimal svc = 0;
                decimal vat = 0;
                decimal room = 0;
                List<GenerateTransactionModel> generateTransactionModels = PropertyUtils.ConvertToList<GenerateTransactionModel>(GenerateTransactionBO.Instance.FindAll()).
                Where(x => x.TransactionCode == transactionCode).ToList();
                #region lấy ra phần trăm giá room, svc và vat
                if (generateTransactionModels.Count > 0)
                {
                    foreach (var item in generateTransactionModels)
                    {
                        if (item.SubgroupCode == "R_MISC")
                        {
                            room = item.Percentage;
                        }
                        if (item.SubgroupCode == "SVC")
                        {
                            svc = item.Percentage;
                        }
                        if (item.SubgroupCode == "Tax")
                        {
                            vat = item.Percentage;
                        }
                    }
                }
                #endregion

                #region tính giá trị net fiexed charge
                decimal vatPrice = price * (vat / 100); 
                decimal svcPrice = price * (svc / 100); 
                decimal priceAfter = price + vatPrice + svcPrice;
                #endregion

                return priceAfter;
            }
            catch (SqlException ex)
            {

                throw new Exception($"Error: {ex.Message}", ex);
            }
        }

        public decimal CalculatePrice(string transactionCode, decimal price)
        {
            try
            {
                decimal svc = 0;
                decimal vat = 0;
                List<GenerateTransactionModel> generateTransactionModels = PropertyUtils.ConvertToList<GenerateTransactionModel>(GenerateTransactionBO.Instance.FindAll()).
                Where(x => x.TransactionCode == transactionCode).ToList();
                #region lấy ra phần trăm svc và vat
                if (generateTransactionModels.Count > 0)
                {
                    foreach (var item in generateTransactionModels)
                    {

                        if (item.SubgroupCode == "SVC")
                        {
                            svc = item.Percentage;
                        }
                        if (item.SubgroupCode == "Tax")
                        {
                            vat = item.Percentage;
                        }
                    }
                }
                #endregion

                #region tính giá trị net fiexed charge
                decimal vatPrice = price * (vat / 100) / (1 + (vat / 100));
                decimal svcPrice = (price - vatPrice) * (svc / 100) / (1 + (svc / 100));
                decimal priceAfter = price - vatPrice - vatPrice;
                #endregion

                return priceAfter;
            }
            catch (SqlException ex)
            {

                throw new Exception($"Error: {ex.Message}", ex);
            }
        }
    }
}
