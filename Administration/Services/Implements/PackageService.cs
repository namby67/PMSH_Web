using System.Data;
using Administration.DTO;
using Administration.Services.Interfaces;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.Data.SqlClient;

namespace Administration.Services.Implements
{
    public class PackageService : IPackageService
    {
        public Task<DataTable> RateCategoryTypeData(string? strPackageCode)
        {
            throw new NotImplementedException();
        }

        public async Task<DataTable> PackageDataByID(int? PackageDataByID)
        {
            throw new NotImplementedException();
        }
        public int Save(PackageDTO dto)
        {
            bool isUpdate = dto.ID > 0;
            PackageModel entity;

            // ===== GET ENTITY =====
            if (isUpdate)
            {
                entity = PackageBO.Instance.FindByPrimaryKey(dto.ID) as PackageModel
                         ?? throw new KeyNotFoundException($"Package not found (ID = {dto.ID})");
            }
            else
            {
                var businessDate = PropertyUtils
                    .ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll())![0]
                    .BusinessDate;

                entity = new PackageModel
                {
                    UserInsertID = dto.UserInsertID,
                    CreateDate = businessDate
                };
            }

            // ===== MAP DTO → ENTITY =====
            entity.Code = dto.Code?.Trim() ?? string.Empty;
            entity.TransCodeAlt = dto.TransCode!.Trim();
            entity.Description = dto.Description!.Trim();
            entity.TextInNightAudit = dto.DisplayInFolio?.Trim() ?? string.Empty;

            entity.ForecastGroupID = dto.ForecastGroupID;
            entity.Type = dto.Type;

            bool isIncluded = dto.DefaultDisplay == 1;
            entity.IncludedInRate = isIncluded;
            entity.RateSeparateLine = !isIncluded;

            entity.Breakfast = dto.Breakfast;
            entity.Lunch = dto.Lunch;
            entity.Dinner = dto.Dinner;

            entity.Active = dto.Active;

            entity.UserUpdateID = dto.UserInsertID;
            entity.UpdateDate = DateTime.Now;

            // ===== SAVE =====
            if (isUpdate)
                PackageBO.Instance.Update(entity);
            else
                PackageBO.Instance.Insert(entity);

            return entity.ID;
        }
    }
}
