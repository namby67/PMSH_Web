using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashiering.Commons.Helpers
{
    public static class ListItemHelper
    {
        private static readonly string _textDefault = "";

        /// <summary>
        /// Lấy tất cả danh sách XONE cho dropdown
        /// </summary>
        /// <param name="defaultValue">Giá trị mặc định.</param>
        /// <param name="textDefault">Text thứ hai.</param>
        /// <returns>Danh sách zONE</returns>
        public static List<SelectListItem> GetZoneProvider(bool defaultValue = true, string textDefault = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textDefault)) textDefault = _textDefault;

                var items = new List<SelectListItem>();
                List<ZoneModel> list = PropertyUtils.ConvertToList<ZoneModel>(ZoneBO.Instance.FindAll());
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


        /// <summary>
        /// Lấy tất cả danh sách Account Type
        /// </summary>
        /// <param name="defaultValue">Giá trị mặc định.</param>
        /// <param name="textDefault">Text thứ hai.</param>
        /// <returns>Danh sách Account Type</returns>
        public static List<SelectListItem> GetARAccountType(bool defaultValue = true, string textDefault = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textDefault)) textDefault = _textDefault;

                var items = new List<SelectListItem>();
                List<ARAccountTypeModel> list = PropertyUtils.ConvertToList<ARAccountTypeModel>(ARAccountTypeBO.Instance.FindAll());
                if (list.Count > 0)
                {
                    items = list.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.Description, Selected = false }).ToList();
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

        /// <summary>
        /// Lấy tất cả danh sách City
        /// </summary>
        /// <param name="defaultValue">Giá trị mặc định.</param>
        /// <param name="textDefault">Text thứ hai.</param>
        /// <returns>Danh sách City</returns>
        public static List<SelectListItem> GetCity(bool defaultValue = true, string textDefault = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textDefault)) textDefault = _textDefault;

                var items = new List<SelectListItem>();
                List<CityModel> list = PropertyUtils.ConvertToList<CityModel>(CityBO.Instance.FindAll());
                if (list.Count > 0)
                {
                    items = list.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.Description, Selected = false }).ToList();
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

        /// <summary>
        /// Lấy tất cả danh sách Country
        /// </summary>
        /// <param name="defaultValue">Giá trị mặc định.</param>
        /// <param name="textDefault">Text thứ hai.</param>
        /// <returns>Danh sách Country</returns>
        public static List<SelectListItem> GetCountry(bool defaultValue = true, string textDefault = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textDefault)) textDefault = _textDefault;

                var items = new List<SelectListItem>();
                List<NationalityModel> list = PropertyUtils.ConvertToList<NationalityModel>(NationalityBO.Instance.FindAll());
                if (list.Count > 0)
                {
                    items = list.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.Description, Selected = false }).ToList();
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
