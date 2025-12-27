using Administration.Services.Implements;
using Administration.Services.Interfaces;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.DataAccess.Sql;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Administration.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger<TransactionController> _logger;
        private readonly IMemoryCache _cache;
        private readonly ITransactionService _iTransactionService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TransactionController(ILogger<TransactionController> logger,
                IMemoryCache cache, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, ITransactionService iTransactionService)
        {
            _cache = cache;
            _logger = logger;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _iTransactionService = iTransactionService;
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Transaction()
        {
            List<TransactionsModel> listTransac = PropertyUtils.ConvertToList<TransactionsModel>(TransactionsBO.Instance.FindAll());
            ViewBag.TransactionsList = listTransac;

            List<TransactionGroupModel> listTransacgroup = PropertyUtils.ConvertToList<TransactionGroupModel>(TransactionGroupBO.Instance.FindAll());
            ViewBag.TransactionGroupList = listTransacgroup;

            List<TransactionSubGroupModel> listTransacsubgroup = PropertyUtils.ConvertToList<TransactionSubGroupModel>(TransactionSubGroupBO.Instance.FindAll());
            ViewBag.TransactionSubGroupList = listTransacsubgroup;

            List<CurrencyModel> listCurr = PropertyUtils.ConvertToList<CurrencyModel>(CurrencyBO.Instance.FindAll());
            ViewBag.CurrencyList = listCurr;

            List<VatTypeModel> listvattype = PropertyUtils.ConvertToList<VatTypeModel>(VatTypeBO.Instance.FindAll());
            ViewBag.VatTypeList = listvattype;

            List<TransactionTypeModel> listTransactionType = PropertyUtils.ConvertToList<TransactionTypeModel>(TransactionTypeBO.Instance.FindAll());
            ViewBag.TransactionTypeList = listTransactionType;

            List<ARAccountReceivableModel> listARAccount = PropertyUtils.ConvertToList<ARAccountReceivableModel>(ARAccountReceivableBO.Instance.FindAll());
            ViewBag.listARAccountList = listARAccount;
            return View();
        }

        #region Transaction 
        [HttpGet]
        public IActionResult SearchTransaction(string code, string description, int groupID, int subGroupID)
        {
            try
            {
                var data = _iTransactionService.SearchTransaction(code ?? "", description ?? "", groupID, subGroupID);

                var result = (from d in data.AsEnumerable()
                              select d.Table.Columns.Cast<DataColumn>()
                                  .ToDictionary(
                                      col => col.ColumnName,
                                      col => d[col.ColumnName]?.ToString()
                                  )).ToList();
                return Json(result);


            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

        }
        int TransactionID = 0;
        int SubGroupID = 0;
        string SubgroupCode = "";
        int GroupID = 0;
        string GroupCode = "";
        int GroupType = 0;
        int GenerateID = 0;
        string AdjCode = "";
        public bool IsProcess = false;

        int OriginSubGroupID = 0;
        string OriginSubgroupCode = "";
        int OriginGroupID = 0;
        string OriginGroupCode = "";
        int OriginGroupType = 0;
        string OriginDesc = "";


        [HttpPost]
        public IActionResult TransactionListSave(TransactionsModel model)
        {
            ProcessTransactions pt = new ProcessTransactions();
            pt.OpenConnection();
            pt.BeginTransaction();

            model.CreatedBy = model.CreatedBy?.Replace("\"", "").Trim();
            List<BusinessDateModel> businessDateModel = PropertyUtils.ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());
            var businessDate = businessDateModel[0].BusinessDate;
            try
            {
                bool isNew = (model.ID == 0);


                if (isNew)
                {
                    model.CreateDate = businessDate;
                    model.UpdateDate = businessDate;

                    TransactionsBO.Instance.Insert(model);
                }
                else
                {
                    TransactionsModel mT = (TransactionsModel)TransactionsBO.Instance.FindByPrimaryKey(model.ID);
                    if (model != null)
                    {

                        SubGroupID = mT.TransactionSubGroupID;
                        GroupID = mT.TransactionGroupID;
                        SubgroupCode = mT.SubgroupCode;
                        GroupCode = mT.GroupCode;
                        GroupType = mT.GroupType;

                        OriginSubGroupID = mT.TransactionSubGroupID;
                        OriginSubgroupCode = mT.SubgroupCode;
                        OriginGroupID = mT.TransactionGroupID;
                        OriginGroupCode = mT.GroupCode;
                        OriginGroupType = mT.GroupType;
                        OriginDesc = mT.Description;
                    }
                    #region Cập nhập thông tin trong bảng GenerateTransactions

                    string[] Field_Exp = { "TransactionCodeDetail" };
                    string[] Field_ExpValue = { model.Code };
                    string[] Field_Change ={ "TransactionGroupID", "GroupCode", "TransactionSubGroupID", "SubGroupCode",
                                                 "GroupType","Description"};
                    string[] Field_ChangeValue ={ model.TransactionGroupID.ToString(),model.GroupCode,model.TransactionSubGroupID.ToString(),model.SubgroupCode,
                                                      model.GroupType.ToString(),model.Description};
                    pt.UpdateAttribute("GenerateTransaction", Field_Exp, Field_ExpValue, Field_Change, Field_ChangeValue);

                    #endregion

                    #region Cập nhập thông tin trong bảng FolioDetail
                    if ((model.TransactionGroupID != OriginGroupID) || (model.GroupCode != OriginGroupCode) || (model.TransactionSubGroupID != OriginSubGroupID)
                        || (model.SubgroupCode != OriginSubgroupCode) || (model.GroupType != OriginGroupType) || (model.Description != OriginDesc))
                    {
                        string[] Field_Exp1 = { "TransactionCode", "Description" };
                        string[] Field_ExpValue1 = { mT.Code, OriginDesc };
                        string[] Field_Change1 = { "TransactionGroupID", "GroupCode", "TransactionSubGroupID", "SubGroupCode", "GroupType", "Description" };
                        string[] Field_ChangeValue1 ={ mT.TransactionGroupID.ToString(),mT.GroupCode,mT.TransactionSubGroupID.ToString(),mT.SubgroupCode,
                                                          mT.GroupType.ToString(),mT.Description};
                        pt.UpdateAttribute("FolioDetail", Field_Exp1, Field_ExpValue1, Field_Change1, Field_ChangeValue1);
                    }
                    #endregion
           
                }

                pt.CommitTransaction();

                return Json(new
                {
                    success = true,
                    message = isNew ? "Insert success!" : "Update success!"
                });
            }
            catch (Exception ex)
            {
                pt.RollBack();
                return BadRequest(new { success = false, message = ex.Message });
            }
            finally
            {
                pt.CloseConnection();
            }
            //return BadRequest(new { success = false });
        }
        [HttpPost]
        public IActionResult TransactionDelete(int  id)
        {
            try
            {

                TransactionsBO.Instance.Delete(id);



                return Json(new { success = true, message = "Transaction  delete successfully." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        [HttpGet]
        public IActionResult SearchGenerate(int code)
        {
            try
            {
                string sql = $"SELECT dbo.GenerateTransaction.TransactionCodeDetail AS TransactionCode, dbo.Transactions.Description, dbo.GenerateTransaction.Percentage, dbo.GenerateTransaction.ID FROM dbo.Transactions INNER JOIN dbo.GenerateTransaction ON dbo.Transactions.Code = dbo.GenerateTransaction.TransactionCodeDetail WHERE TransactionCode = '{code}' ORDER BY dbo.GenerateTransaction.ID ASC";

                DataTable dataTable = TextUtils.Select(sql);

                var result = (from d in dataTable.AsEnumerable()
                              select new
                              {
                                  TransactionCode = d["TransactionCode"]?.ToString() ?? "",
                                  Description = d["Description"]?.ToString() ?? "",
                                  Percentage = d["Percentage"]?.ToString() ?? "",
                                  ID = d["ID"]?.ToString() ?? ""

                              }).ToList();
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult GenerateSave(int ID,string transactionsGernew ,int percentagetext,int percengegre,int  amountPer,string formular,int percenOption,string CreatedBy,int UserInsertID,int subTotal1,int subTotal2,int subTotal3)
        {
            ProcessTransactions pt = new ProcessTransactions();
            pt.OpenConnection();
            pt.BeginTransaction();

            CreatedBy = CreatedBy?.Replace("\"", "").Trim();
            List<BusinessDateModel> businessDateModel = PropertyUtils.ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());
            var businessDate = businessDateModel[0].BusinessDate;
            try
            {
                bool isNew = (ID == 0);

                TransactionsModel tran = (TransactionsModel)TransactionsBO.Instance.FindByAttribute("Code", transactionsGernew)[0];
                if (isNew)
                {
                    GenerateTransactionModel objModel = new GenerateTransactionModel();
                    objModel.TransactionCode = transactionsGernew;
                    objModel.Description = tran.Description;
                    objModel.TransactionCodeDetail = transactionsGernew;
                    if (percenOption == 1)
                    {
                        #region Percentage
                        try
                        {
                            objModel.Percentage = percentagetext;
                        }
                        catch
                        {
                            objModel.Percentage = 0;
                        }
                        #endregion
                        objModel.Amount = 0;
                        objModel.UDFFunction = "";
                        objModel.Type = 0;
                    }
                    if (percenOption == 2)
                    {
                        objModel.Percentage = 0;
                        #region Amount
                        try
                        {
                            objModel.Amount = amountPer;
                        }
                        catch
                        {
                            objModel.Amount = 0;
                        }
                        #endregion
                        objModel.UDFFunction = "";
                        objModel.Type = 1;
                    }
                    if (percenOption == 3)
                    {
                        objModel.Percentage = 0;
                        objModel.Amount = 0;
                        objModel.UDFFunction = "";
                        objModel.Type = 2;
                    }
                    objModel.BaseAmount = percengegre;
                    objModel.Subtotal1 = subTotal1 == 1;
                    objModel.Subtotal2 = subTotal2 == 1;
                    objModel.Subtotal3 = subTotal3 == 1;



                    objModel.GroupCode = tran.GroupCode;
                    objModel.SubgroupCode = tran.SubgroupCode;
                    objModel.TransactionSubGroupID = tran.TransactionSubGroupID;
                    objModel.TransactionGroupID = tran.TransactionGroupID;
                    objModel.GroupType = tran.GroupType;

                    GenerateTransactionBO.Instance.Insert(objModel);
                }
                else
                {
                    GenerateTransactionModel objModel = (GenerateTransactionModel)GenerateTransactionBO.Instance.FindByPrimaryKey(ID);
                    objModel.TransactionCode = transactionsGernew;
                    objModel.Description = tran.Description;
                    objModel.TransactionCodeDetail = transactionsGernew;
                    if (percenOption == 1)
                    {
                        #region Percentage
                        try
                        {
                            objModel.Percentage = percentagetext;
                        }
                        catch
                        {
                            objModel.Percentage = 0;
                        }
                        #endregion
                        objModel.Amount = 0;
                        objModel.UDFFunction = "";
                        objModel.Type = 0;
                    }
                    if (percenOption == 2)
                    {
                        objModel.Percentage = 0;
                        #region Amount
                        try
                        {
                            objModel.Amount = amountPer;
                        }
                        catch
                        {
                            objModel.Amount = 0;
                        }
                        #endregion
                        objModel.UDFFunction = "";
                        objModel.Type = 1;
                    }
                    if (percenOption == 3)
                    {
                        objModel.Percentage = 0;
                        objModel.Amount = 0;
                        objModel.UDFFunction = "";
                        objModel.Type = 2;
                    }
                    objModel.BaseAmount = percengegre;
                    objModel.Subtotal1 = subTotal1 == 1;
                    objModel.Subtotal2 = subTotal2 == 1;
                    objModel.Subtotal3 = subTotal3 == 1;



                    objModel.GroupCode = tran.GroupCode;
                    objModel.SubgroupCode = tran.SubgroupCode;
                    objModel.TransactionSubGroupID = tran.TransactionSubGroupID;
                    objModel.TransactionGroupID = tran.TransactionGroupID;
                    objModel.GroupType = tran.GroupType;

                    GenerateTransactionBO.Instance.Update(objModel);

                }

                pt.CommitTransaction();

                return Json(new
                {
                    success = true,
                    message = isNew ? "Insert success!" : "Update success!"
                });
            }
            catch (Exception ex)
            {
                pt.RollBack();
                return BadRequest(new { success = false, message = ex.Message });
            }
            finally
            {
                pt.CloseConnection();
            }
            //return BadRequest(new { success = false });
        }
        [HttpGet]
        public IActionResult SearchGenerateDetail(int id)
        {
            try
            {
                string sql = $"SELECT * FROM dbo.GenerateTransaction  WHERE ID = '{id}'";

                DataTable dataTable = TextUtils.Select(sql);

                var result = (from d in dataTable.AsEnumerable()
                              select new
                              {
                                  ID = d["ID"]?.ToString() ?? "",
                                  GenerateGroupID = d["GenerateGroupID"]?.ToString() ?? "",
                                  TransactionGroupID = d["TransactionGroupID"]?.ToString() ?? "",
                                  TransactionSubGroupID = d["TransactionSubGroupID"]?.ToString() ?? "",
                                  GroupCode = d["GroupCode"]?.ToString() ?? "",
                                  SubgroupCode = d["SubgroupCode"]?.ToString() ?? "",
                                  GroupType = d["GroupType"]?.ToString() ?? "",
                                  Type = d["Type"]?.ToString() ?? "",
                                  TransactionCode = d["TransactionCode"]?.ToString() ?? "",
                                  TransactionCodeDetail = d["TransactionCodeDetail"]?.ToString() ?? "",
                                  Description = d["Description"]?.ToString() ?? "",
                                  Percentage = d["Percentage"]?.ToString() ?? "",
                                  Amount = d["Amount"]?.ToString() ?? "",
                                  UDFFunction = d["UDFFunction"]?.ToString() ?? "",
                                  BaseAmount = d["BaseAmount"]?.ToString() ?? "",
                                  Subtotal1 = d["Subtotal1"]?.ToString() ?? "",
                                  Subtotal2 = d["Subtotal2"]?.ToString() ?? "",
                                  Subtotal3 = d["Subtotal3"]?.ToString() ?? ""

                              }).ToList();
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
    }

}