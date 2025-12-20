using Administration.DTO;
using Administration.Services.Interfaces;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;

namespace Administration.Services.Implements
{
    public class PackageDetailService : IPackageDetailService
    {
        public List<PackageDetailDTO> GetPackageDetailsByPackageID(int packageId)
        {
            var list = PackageDetailBO.Instance
                .FindByAttribute("PackageID", packageId)
                .Cast<PackageDetailModel>()
                .ToList();

            var dtoList = new List<PackageDetailDTO>();

            foreach (var item in list)
            {
                var dto = new PackageDetailDTO
                {
                    ID = item.ID,
                    PackageID = item.PackageID,
                    SeasonID = item.SeasonID,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    TransCode = string.IsNullOrEmpty(item.TransCode) ? "No Value" : item.TransCode,
                    ArticlesCode = item.ArticlesCode,
                    TransCodeOver = item.TransCodeOver,
                    ArticlesCodeOver = item.ArticlesCodeOver,
                    Description = item.Description,
                    Price = item.Price,
                    CurrencyID = item.CurrencyID,
                    AllowanceAmount = item.AllowanceAmount,
                    RhythmPostingID = item.RhythmPostingID,
                    CalculationRuleID = item.CalculationRuleID,
                    PostingDate = item.PostingDate,
                    PostingDay = item.PostingDay,
                    PriceAfterTax = item.PriceAfterTax,
                    IsTaxInclude = item.IsTaxInclude,
                    UserInsertID = item.UserInsertID,
                    CreateDate = item.CreateDate,
                    UserUpdateID = item.UserUpdateID,
                    UpdateDate = item.UpdateDate,
                    TransactionDescription = "" // khởi tạo mặc định
                };

                // Lấy transaction description
                var transList = TransactionsBO.Instance.FindByAttribute("Code", dto.TransCode);

                if (transList != null && transList.Count > 0)
                {
                    foreach (var obj in transList)
                    {
                        if (obj is TransactionsModel transaction && !string.IsNullOrEmpty(transaction.Description))
                        {
                            if (!string.IsNullOrEmpty(dto.TransactionDescription))
                                dto.TransactionDescription += "; ";
                            dto.TransactionDescription += transaction.Description;
                        }
                    }
                }

                if (string.IsNullOrEmpty(dto.TransactionDescription))
                {
                    dto.TransactionDescription = "No description available";
                }

                dtoList.Add(dto);
            }

            return dtoList;
        }

        public int Save(PackageDetailDTO dto)
        {
            bool isUpdate = dto.ID > 0;
            PackageDetailModel entity;
            //Get entity
            if (isUpdate)
            {
                entity = PackageDetailBO.Instance.FindByPrimaryKey(dto.ID) as PackageDetailModel
                ?? throw new KeyNotFoundException($"Package Detail not found (ID = {dto.ID})");
            }
            else
            {
                var businessDate = PropertyUtils.ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll())![0].BusinessDate;
                if (!dto.PackageID.HasValue)
                    throw new ArgumentException("PackageID is required");

                entity = new PackageDetailModel
                {
                    UserInsertID = dto.UserInsertID,
                    CreateDate = businessDate,
                    PackageID = dto.PackageID.Value,
                    PostingDate = businessDate
                };
            }
            //Map DTO
            // Get transaction info
            if (string.IsNullOrWhiteSpace(dto.TransCode))
            {
                throw new ArgumentException("TransCode cannot be null or empty");
            }
            var transactions = PropertyUtils.ConvertToList<TransactionsModel>(
                TransactionsBO.Instance.FindByAttribute("Code", dto.TransCode)
            );

            var transaction = transactions?.FirstOrDefault()
                ?? throw new KeyNotFoundException($"Transaction not found (Code = {dto.TransCode})");

            entity.SeasonID = dto.SeasonID;
            entity.StartDate = dto.StartDate;
            entity.EndDate = dto.EndDate;
            entity.TransCode = dto.TransCode;
            entity.Description = transaction.Description;
            entity.Price = dto.Price ?? 0;
            entity.CurrencyID = dto.CurrencyID;
            entity.RhythmPostingID = dto.RhythmPostingID;
            entity.CalculationRuleID = dto.CalculationRuleID ?? 0;
            entity.PriceAfterTax = dto.PriceAfterTax ?? 0;
            entity.IsTaxInclude = !transaction.TaxInclude;
            entity.UserUpdateID = dto.UserUpdateID ?? 0;
            entity.UpdateDate = dto.UpdateDate;

            //Save
            if (isUpdate)
            {
                PackageDetailBO.Instance.Update(entity);
            }
            else
            {
                PackageDetailBO.Instance.Insert(entity);
            }
            // Trả về Package để gọi Lại full cả package lẫn package detail
            return entity.PackageID;
        }
    }

}
