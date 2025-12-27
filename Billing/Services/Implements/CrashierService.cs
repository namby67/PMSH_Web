using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using BaseBusiness.Util;
using Billing.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Services.Implements
{
    public class CrashierService : ICrashierService
    {
        public ShiftModel Login(string LoginName, string Password)
        {
            try
            {
                string PasswordHash = MD5.Encrypt(Password);
                var list = PropertyUtils.ConvertToList<UsersModel>(UsersBO.Instance.FindAll()).Where(x => x.LoginName == LoginName && x.PasswordHash == PasswordHash).ToList();
                if (list.Count > 0)
                {
                    List<BusinessDateModel> businessDateModel = PropertyUtils.ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());

                    if (ShiftBO.GetShiftByUser(businessDateModel[0].BusinessDate, list[0].ID).Count > 0)
                    {
                        var item = ShiftBO.GetShiftByUser(businessDateModel[0].BusinessDate, list[0].ID)[0];
                        // Combine the date from businessDateModel[0].BusinessDate with the current time
                        item.LoginTime = businessDateModel[0].BusinessDate.Date + DateTime.Now.TimeOfDay;
                        item.UserUpdateID = list[0].ID;
                        item.UpdateDate = DateTime.Now;
                        ShiftBO.Instance.Update(item);
                        return item;
                    }
                    else
                    {
                        ShiftModel shift = new ShiftModel();
                        shift.LoginTime = shift.LogoutTime = businessDateModel[0].BusinessDate.Date + DateTime.Now.TimeOfDay;
                        shift.UserID = shift.UserInsertID = shift.UserUpdateID = list[0].ID;
                        shift.UserName = list[0].LoginName;
                        shift.CreateDate = shift.UpdateDate = DateTime.Now;
                        shift.Status = false;
                        ShiftBO.Instance.Insert(shift);
                        return shift;
                    }
                }

                return new ShiftModel();
            }
            catch (Exception ex)
            {
                return new ShiftModel();
            }
        }
    }
}
