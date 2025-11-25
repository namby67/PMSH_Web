using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;


namespace BaseBusiness.util
{
    public class StaticFunction
    {
        public static string displayDate(DateTime dtInput)
        {
            string dtReturn = "";
            if ((dtInput > StaticParam.mindate) && (dtInput < StaticParam.maxdate))
                dtReturn = dtInput.ToString("dd/MM/yyyy");
            else
                dtReturn = "";
            return dtReturn;
        }

        public static string Date2DB(DateTime dtInput)
        {
            string dtReturn = "";
            if ((dtInput > StaticParam.mindate) && (dtInput < StaticParam.maxdate))
                dtReturn = dtInput.ToString("yyyy-MM-dd");
            else
                dtReturn = StaticParam.mindate.ToString("yyyy-MM-dd");
            return dtReturn;
        }

        public static string displayDateWithTime(DateTime dtInput)
        {
            string dtReturn = "";
            if ((dtInput > StaticParam.mindate) && (dtInput < StaticParam.maxdate))
                dtReturn = dtInput.ToString("dd/MM/yyyy hh:mm:ss");
            else
                dtReturn = "";
            return dtReturn;
        }

        public static string displayDateWithTime24H(DateTime dtInput)
        {
            string dtReturn = "";
            if ((dtInput > StaticParam.mindate) && (dtInput < StaticParam.maxdate))
                dtReturn = dtInput.ToString("dd/MM/yyyy HH:mm:ss");
            else
                dtReturn = "";
            return dtReturn;
        }

        public static DateTime returnMindateIfNull(string dtInput)
        {
            DateTime dtReturn = StaticParam.mindate;
            if (dtInput.Trim()=="")
                dtReturn = StaticParam.mindate;
            else
               dtReturn =System.DateTime.Parse(dtInput, new CultureInfo("vi-VN", true));
            return dtReturn;
        }
        public static DateTime returnCurrDateIfNull(string dtInput)
        {
            DateTime dtReturn = StaticParam.mindate;
            if (dtInput.Trim() == "")
                dtReturn = DateTime.Now;
            else
                dtReturn = System.DateTime.Parse(dtInput, new CultureInfo("vi-VN", true));
            return dtReturn;
        }

        public static DateTime returnMaxdateIfNull(string dtInput)
        {
            DateTime dtReturn = StaticParam.maxdate;
            if (dtInput.Trim() == "")
                dtReturn = StaticParam.maxdate;
            else
                dtReturn = System.DateTime.Parse(dtInput, new CultureInfo("vi-VN", true));
            return dtReturn;
        }

        public static Decimal getDecimal(string decInput)
        {
            Decimal decReturn = 0;
            try
            {
                //decInput = decInput.Trim().Replace(",", "").Replace(".", ",");
                //decReturn = Decimal.Parse(decInput);
                decReturn = (Decimal.Parse(decInput,
                   System.Globalization.NumberStyles.AllowParentheses |
                   System.Globalization.NumberStyles.AllowLeadingWhite |
                   System.Globalization.NumberStyles.AllowTrailingWhite |
                   System.Globalization.NumberStyles.AllowThousands |
                   System.Globalization.NumberStyles.AllowDecimalPoint |
                   System.Globalization.NumberStyles.AllowLeadingSign));
            }
            catch
            {
                decReturn = 0;
            }

            return decReturn;
        }
        public static Decimal getDecimalFromExcel(string decInput)
        {
            Decimal decReturn = 0;
            try
            {
                //decInput = decInput.Trim().Replace(",", "").Replace(".", ",");
                 decReturn = (Decimal.Parse(decInput,
                 System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign));
            }
            catch
            {
                decReturn = 0;
            }

            return decReturn;
        }


        public static int getInteger(string intInput)
        {
            int intReturn = 0;
            try
            {
                intReturn = int.Parse(intInput);

            }
            catch
            {
                intReturn = 0;
            }

            return intReturn;
        }

        public static string FormatCurrencyVND(Decimal x)
        {
            return (x.ToString("#,0.##", CultureInfo.InvariantCulture));
        }
        public static string DecimalToString(Decimal x)
        {
            string outValue = "";
           if (x == 0)
                outValue = "";
            else
                outValue = FormatCurrencyVND(x);
            return outValue;

        }

        public static string DecimalToStringReturnRezo(Decimal x)
        {
            string outValue = "";
            if (x == 0)
                outValue = "0";
            else
                outValue = FormatCurrencyVND(x);
            return outValue;

        }

        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }


        //public static string codeFormat(int SEQ)
        //{
        //    string strReturn = SEQ.ToString("0000000");
        //    return strReturn;
        //}

       
        public static string DecimalToStringForChart(Decimal x)
        {
            string outValue = "";
            try
            {
                if (x == 0)
                    outValue = "0";
                else
                    outValue = x.ToString("N0");
            }
            catch
            {
                outValue = "0";
            }
            outValue = outValue.Replace(",", "");
            outValue = outValue.Replace(".", "");
            return outValue;

        }

        public static string fileNameAdd()
        {
            return DateTime.Now.ToString("yyyyMMddhhmm_");
        }

        public static Boolean IsDate(string strDate)
        {
            try
            {
                //DateTime.Parse(strDate,new CultureInfo("vi-VN", true));
                DateTime.Parse(strDate);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean IsDateWithEmpty(string strDate)
        {
            if (strDate.Trim() == "")
            {
                return true;
            }
            else
            {
                try
                {
                    DateTime.Parse(strDate);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
       

    }

}
