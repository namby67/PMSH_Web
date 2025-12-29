using System;
using System.Collections;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using BaseBusiness.bc;
using System.Collections.Generic;
using System.Data;

namespace BaseBusiness.util
{
    /// <summary>
    /// Summary description for PropertyUtils.
    /// </summary>
    public class PropertyUtils
    {
        public static object PopulateObject(SqlDataReader dr, object model)
        {
            foreach (PropertyInfo p in model.GetType().GetProperties())
            {
                if (!p.CanWrite) continue;
                Object value = dr[p.Name];
                if (value != DBNull.Value)
                    p.SetValue(model, value, null);
            }
            return model;
        }

        public static object PopulateObject(SqlDataReader dr, string fullname)
        {
            Object model = Activator.CreateInstance(Type.GetType(fullname));
            return PopulateObject(dr, model);
        }

        public static BaseModel PopulateModel(SqlDataReader dr, string name)
        {
            return (BaseModel)PropertyUtils.PopulateObject(dr, name);
        }

        /* Populate object in SQL data reader into corresponding model with selected property */
        public static object PopulateObject(SqlDataReader dr, object model, ArrayList listPropertyName)
        {
            foreach (PropertyInfo p in model.GetType().GetProperties())
            {
                if (contains(listPropertyName, p.Name))
                {
                    if (!p.CanWrite) continue;
                    Object value = dr[p.Name];
                    if (value != DBNull.Value)
                        p.SetValue(model, value, null);
                }
            }
            return model;
        }

        /* Check if checkItem is in list */
        private static bool contains(ArrayList list, string checkItem)
        {
            foreach (string item in list)
            {
                if (item.Equals(checkItem)) return true;
            }
            return false;
        }
        public static DataTable ConvertToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        public static BaseModel PopulateModel(SqlDataReader dr, string name, ArrayList listPropertyName)
        {
            return (BaseModel)PropertyUtils.PopulateObject(dr, name, listPropertyName);
        }

        public static object PopulateObject(SqlDataReader dr, string fullname, ArrayList listProperty)
        {
            Object model = null;
            try
            {
                model = Activator.CreateInstance(Type.GetType(fullname));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return PopulateObject(dr, model, listProperty);
        }

        public static object GetValue(object model, string fieldname)
        {
            PropertyInfo p = model.GetType().GetProperty(fieldname);
            return p != null ? p.GetValue(model, null) : null;
        }

        public static object[] GetPropertyValues(object model)
        {
            PropertyInfo[] pList = model.GetType().GetProperties();
            object[] values = new object[pList.Length];
            for (int i = 0; i < pList.Length; i++)
            {
                if (pList[i].CanRead)
                    values[i] = GetValue(model, pList[i].Name);
            }
            return values;
        }

        public static object[] GetPropertyValues(object model, string CommaSeparatedFieldString)
        {
            string[] fields = CommaSeparatedFieldString.Split(',');
            object[] values = new object[fields.Length];
            int i = 0;
            foreach (string field in fields)
            {
                values[i++] = GetValue(model, field.Trim());
            }
            return values;
        }

        public static string ToList(ArrayList list, string c)
        {
            StringBuilder result = new StringBuilder();
            foreach (object item in list)
            {
                result.Append(item.ToString() + c);
            }
            string r = result.ToString();
            return r.Length > 1 ? r.Substring(0, result.Length - c.Length) : "";
        }

        public static string ToList(ArrayList list, string fieldname, string c)
        {
            StringBuilder result = new StringBuilder();
            foreach (object item in list)
            {
                result.Append(GetValue(item, fieldname) + c);
            }
            string r = result.ToString();
            return r.Length > 1 ? r.Substring(0, result.Length - c.Length) : "";
        }

        public static string ToListWithComma(ArrayList list, string fieldname)
        {
            return ToList(list, fieldname, ",");
        }

        public static string ToListWithStringComma(ArrayList list, string fieldname)
        {
            return string.Format("'{0}'", ToList(list, fieldname, "','"));
        }

        public static string ToListWithComma(ArrayList list)
        {
            return ToList(list, ",");
        }

        public static string ToListWithSemicolon(ArrayList list, string fieldname)
        {
            return ToList(list, fieldname, ";");
        }

        public static List<T> ConvertToList<T>(ArrayList list)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            List<T> newList = new List<T>(list.Count);

            foreach (object obj in list)
                newList.Add((T)obj);
            return newList;
        }

        public static List<T> ConvertArrayToList<T>(object[] array)
        {
            if (array == null)
                throw new ArgumentNullException("list");

            List<T> newList = new List<T>(array.Length);

            foreach (object obj in array)
                newList.Add((T)obj);

            return newList;
        }
        //		public static string ToList1(ArrayList list, string fieldname, string c)
        //		{
        //			StringBuilder result = new StringBuilder();
        //			foreach (object item in list)
        //			{
        //				result.Append("'" + GetValue(item, fieldname) + "'" + c);
        //			}
        //			string r = result.ToString();
        //			return r.Length > 1 ? r.Substring(0, result.Length - c.Length) : "";
        //		}
        //
        //		public static string ToListWithComma1(ArrayList list, string fieldname)
        //		{
        //			return ToList1(list, fieldname, ", ");
        //		}
    }
}