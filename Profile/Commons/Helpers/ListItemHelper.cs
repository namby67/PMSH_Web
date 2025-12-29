using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Commons.Helpers
{
    public static class ListItemHelper
    {
        private static readonly string _textDefault = "";

        /// <summary>
        /// Lấy tất cả danh sách member type cho dropdown
        /// </summary>
        /// <param name="defaultValue">Giá trị mặc định.</param>
        /// <param name="textDefault">Text thứ hai.</param>
        /// <returns>Danh sách nationality</returns>
        public static List<SelectListItem> GetMemberTypeProvider(bool defaultValue = true, string textDefault = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textDefault)) textDefault = _textDefault;

                var items = new List<SelectListItem>();
                List<MemberTypeModel> list = PropertyUtils.ConvertToList<MemberTypeModel>(MemberTypeBO.Instance.FindByAttribute("Inactive", 0));
                if (list.Count > 0)
                {
                    items = list.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.Code, Selected = false }).ToList();
                }
                if (defaultValue)
                    items.Insert(0, new SelectListItem { Text = textDefault, Value = "0", Selected = true });

                return items;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new List<SelectListItem>();
            }
        }

        
    }
}
