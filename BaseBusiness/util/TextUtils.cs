
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;

namespace BaseBusiness.util
{
	/// <summary>
	/// Summary description for TextUtils.
	/// </summary>
	public class TextUtils
	{
		public TextUtils()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public static DateTime dtNull=DateTime.Parse("01/01/1900");

		public static string ToString(Object obj)
		{
			return (obj == null) ? "" : obj.ToString();
		}
        public static int CompareDate(DateTime date1, DateTime date2)
        {
            if (date1.Day == date2.Day && date1.Month == date2.Month && date1.Year == date2.Year)
                return 0;
            if (date1.Year < date2.Year || (date1.Year == date2.Year && date1.Month < date2.Month) || (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day < date2.Day))
                return -1;
            else
                return 1;

        }
        public static string GetHostName()
        {
            return System.Environment.MachineName; //System.Net.Dns.GetHostName();

        }
        public static int ToInt(string x)
		{
			try
			{
				return int.Parse(x);
			}
			catch (Exception e)
			{
				return -1;
			}
		}
        public static Decimal ToDecimal(string x)
        {
            try
            {
                return Decimal.Parse(x);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static string DateFormatEnVi(DateTime dtDate,int EnVi,  string dtFormat)
        {
            //If Eng date, EnVi=1, if Vi date EnVi=0
            //dtFormat: dd/MM/yyyy,....
            CultureInfo culture;
            try
            {
                if(EnVi==1)
                    culture = new CultureInfo("en-us");
                else
                    culture = new CultureInfo("vi-VN");

                return dtDate.ToString(dtFormat, culture);
                
            }
            catch (Exception e)
            {
                return "";
            }
        }

		public static long ToLong(string x)
		{
			try
			{
				return long.Parse(x);
			}
			catch (Exception e)
			{
				return -1;
			}
		}

		//TUANLA add this function
		public static System.Boolean IsDate (string strDate)
		{
			try
			{
				if(strDate.Length < 7)
					return false;
				System.DateTime dt = System.DateTime.Parse(strDate,new CultureInfo("vi-VN", true));
				return true;
			}
			catch
			{
				return false;
			}
		}
		public static System.Boolean IsNumeric (System.Object Expression)
		{
			if(Expression == null || Expression is DateTime)
				return false;

			if(Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
				return true;
  
			try
			{
				if(Expression is string)
					Double.Parse(Expression as string);
				else
					Double.Parse(Expression.ToString());
					return true;
			} 
			catch {} // just dismiss errors but return false
			return false;
		}

		public static Decimal ToReal(string x)
		{
			try
			{
				return Decimal.Parse(x);
			}
			catch (Exception e)
			{
				return 0;
			}
		}

		//		public static int EncodeIP(string ip)
		//		{
		//			string[] abc = ip.Split('.');
		//			int str1, str2, str3, str4, result;
		//			str1 = int.Parse(abc[0]) << 24;
		//			str2 = int.Parse(abc[1]) << 16;
		//			str3 = int.Parse(abc[2]) << 8;
		//			str4 = int.Parse(abc[3]);
		//			result = (int) (str1 + str2 + str3 + str4 - 2147483648);
		//
		//			return result;
		//		}
		//
		//		public static string DecodeIP(int hexIP)
		//		{
		//			long str1, str2, str3, str4;
		//			long temp = hexIP + 2147483648;
		//			str1 = temp & 0xFF;
		//			str2 = (temp >> 8) & 0xFF;
		//			str3 = (temp >> 16) & 0xFF;
		//			str4 = (temp >> 24) & 0xFF;
		//			return str4 + "." + str3 + "." + str2 + "." + str1;
		//		}

		private static DateTime EMPTY_DATE = new DateTime(1, 1, 1);
		private static DateTime VABS_MAX_DATE = DateTime.Parse("1/1/2099");
		private static DateTime MIN_DATE = DateTime.MinValue;
		private static DateTime MAX_DATE = DateTime.MaxValue;

		public static string FormatDate(DateTime date, string format)
		{
			//if(date.Equals("1/1/2099") || date.Equals("1/1/1")) return "N/A";
			//if (date.Equals(EMPTY_DATE) || date.Equals(MIN_DATE) || date.Equals(VABS_MAX_DATE) || date.Equals(MAX_DATE)) return "N/A";
			if (date.Year < 1000 || date.Year >= 2099) return "N/A";
			return date.ToString(format, DateTimeFormatInfo.InvariantInfo);
		}

		public static string FormatDate(DateTime date)
		{
			return FormatDate(date, "MMM dd, yyyy");
		}

		public static string FormatDateTime(DateTime date)
		{
			//return FormatDate(date, "U");
			return FormatDate(date, "MMM dd, yyyy HH:mm:ss");
		}

		public static string FormatDateToMonthAndYear(string date)
		{
			return FormatDate(ToDate(date), "MMM, yyyy");
		}

		public static string FormatDate(string date)
		{
			return FormatDate(ToDate(date), "MMM dd, yyyy");
		}
		public static string FormatDate4Invoice(DateTime date)
		{
			return FormatDate(date, "dd-MMM-yyyy");
		}
		public static string FormatDate4InvoicePeriod(DateTime date)
		{
			return FormatDate(date, "yyyy-MMM-dd").ToUpper();
		}
		public static DateTime ToDate(string date)
		{
			return DateTime.Parse(date, new CultureInfo("en-US", true));
		}

		public static string ToString1(DateTime date)
		{
			//return date.ToString("MMM, dd yyyy", new CultureInfo("en-US", true));
			return date.ToString("MM/dd/yyyy", new CultureInfo("en-US", true));
		}
		
		public static string ToStringVN(DateTime date)
		{			
			return date.ToString("dd/MM/yyyy", new CultureInfo("vi-VN", true));
		}

		public static string GetFullMonth(DateTime date)
		{
			//return FormatDate(date, "U");
			return FormatDate(date, "MMMM");
		}

        public static string FormatDateToMonthNDay(DateTime date)
        {
            return FormatDate(date, "MMM dd");
        }

        public static string FormatDateToMonthNDayVN(DateTime date)
        {            
            return "ngày "+date.ToString("dd MMMMMMM", new CultureInfo("vi-VN", true));
        }

		/// <summary>
		/// ////////////////////////////////////////////////////////////////////////////
		/// </summary>
		private static string[] Number_Patterns =
			new string[] {"{0:#,##0}", "{0:#,##0.0}", "{0:#,##0.00}", "{0:#,##0}.000", "{0:#,##0.0000}", "{0:#,##0.00000;#,##0.00000; }"};

		private static string[] Currency_Patterns =
			new string[] {"{0:$#,##0;($#,##0); }", "{0:$#,##0.0;($#,##0.0); }", "{0:$#,##0.00;($#,##0.00); }", "{0:$#,##0.000;($#,##0.000); }", "{0:$#,##0.0000;($#,##0.0000); }", "{0:$#,##0.00000;($#,##0.00000); }"};

        private static string[] VNCurrency_Patterns =
            new string[] { "{0:#,##0;(#,##0); }", "{0:#,##0.0;(#,##0.0); }", "{0:#,##0.00;(#,##0.00); }", "{0:#,##0.000;(#,##0.000); }", "{0:#,##0.0000;(#,##0.0000); }", "{0:#,##0.00000;(#,##0.00000); }" };


		public static string FormatNumber(Decimal x, int digits)
		{
			return String.Format(Number_Patterns[digits], x);
		}

		public static string FormatCurrency(Decimal x, int digits)
		{
			return String.Format(Currency_Patterns[digits], x);
            //return String.Format(VNCurrency_Patterns[digits], x);
             
		}

		public static string FormatNumberZeroToDash(Decimal x)
		{
			return String.Format("{0:#,##0.00;(#,##0.00); }", x);
		}

		public static string FormatPercentNumber(Decimal x)
		{
			return String.Format("{0:#0.00}%", x);
		}

		

        public static string SpaceIfEqualZero(Decimal x)
        {
            //return String.Format("{0:#0.00}%", x);
            if (x == 0)
                return "";
            else
                return x.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }
        public static DataTable Select(string strComm)
        {
            using (SqlConnection cnn = new SqlConnection(DBUtils.GetDBConnectionString()))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(strComm, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 0;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            cnn.Open();
                            da.Fill(ds);
                            return ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
                        }
                    }
                }
                catch (SqlException se)
                {
                    throw new Exception("Select error: " + se.Message);
                }
            }
        }
        public static string SalaryToString(Decimal x, params object[] optionalParamArray)
        {
            string displayType = "",strReturn="";
            try
            {
                displayType = optionalParamArray.GetValue(0).ToString();
            }
            catch
            {
                displayType = "";
            }
            if(x==0)
            {
                if (displayType == "1")
                    strReturn = "N/A";
                else
                    strReturn = "";

            }
            else
            {
                strReturn = TextUtils.FormatNumber(x, 0);
            }
            
            return strReturn.Replace(".",",");
        }

        public static string SalaryList(string strx)
        {
            string displayType = "", strReturn = "";
            if (strx.Trim() == "") strx = "0";
            Decimal x = Decimal.Parse(strx);
            if (x == 0)
            {
               
                    strReturn = "";

            }
            else
            {
                strReturn = TextUtils.FormatNumber(x, 0);
            }

            return strReturn.Replace(".", ",");
        }
		public static Decimal RoundForPort(Decimal x,Decimal nRound)
		{
           if(Math.Abs(x)<= nRound)
				return 0;
			else
				return x;
			
		}
		public static ArrayList SplitPrefixes(string rawPref)
		{
			ArrayList prefList = new ArrayList();
			try
			{
				string[] prefParts = rawPref.Split(';');
				for (int i = 0; i < prefParts.Length; i++)
				{
					string[] temp = prefParts[i].Split('-');
					//string t = temp[0];string t1 = prefParts[i];
					if (temp.Length == 1) //no "-"
					{
						if (!prefList.Contains(temp[0].Trim())) prefList.Add(temp[0].Trim());
					}
					else if (temp.Length == 2) //one "-"
					{
						int noOfPrefs = int.Parse(temp[1]) - int.Parse(temp[0]);
						for (int j = 0; j <= noOfPrefs; j++)
						{
							if (!prefList.Contains((int.Parse(temp[0]) + j).ToString().Trim())) 
								prefList.Add((int.Parse(temp[0]) + j).ToString().Trim());
						}
					}
					else//more than one "-"
					{
						prefList.Clear();
					}
				}
			}
			catch
			{
				return prefList;
			}
			return prefList;
		}

		public static string[] SplitBillingIncrement(string rawIncr, out bool isValid)
		{
			isValid = false;
			Double result;
			string[] incrParts = rawIncr.Split('+');
			if (incrParts.Length != 2) return incrParts;
			for (int i = 0; i < incrParts.Length; i++)
			{
				if (!Double.TryParse(incrParts[i].ToString(), NumberStyles.Number, NumberFormatInfo.CurrentInfo, out result))
					return incrParts;
				if (result != int.Parse(result.ToString()) || result <= 0||result>60)
					return incrParts;
			}
			isValid = true;
			return incrParts;
		}

		public static string Error(string msg)
		{
			return "ERROR: " + msg;
		}

		public static string Warn(string msg)
		{
			return "WARNING: " + msg;
		}

		public static string ToHTML(NameValueCollection list)
		{
			StringBuilder r = new StringBuilder();
			foreach(string key in list.AllKeys)
			{
				r.Append("<span class=subtitle2>" +key + "</span>: " + list.Get(key) + "<br>");
			}
			return r.ToString();
		}

		public static bool NotNull(object obj)
		{
			if(obj == null) return false;
			if(obj is string & ((string)obj).Trim().Length == 0) return false;
			return true;
		}
		public static DateTime GetFirstDayOfWeek(DateTime day)
		{
			switch(day.DayOfWeek)
			{
				case DayOfWeek.Tuesday:
					return day.AddDays(-1);
				case DayOfWeek.Wednesday:
					return day.AddDays(-2);
				case DayOfWeek.Thursday:
					return day.AddDays(-3);
				case DayOfWeek.Friday:
					return day.AddDays(-4);
				case DayOfWeek.Saturday:
					return day.AddDays(-5);
				case DayOfWeek.Sunday:
					return day.AddDays(-6);
			}
			return day;
		}
		//Method to parse Text into HTML
		public static string parsetext(string text, bool allow)
		{
			//Create a StringBuilder object from the string input
			//parameter
			StringBuilder sb = new StringBuilder(text) ;
			//Replace all double white spaces with a single white space
			//and &nbsp;
			sb.Replace("  "," &nbsp;");
			//Check if HTML tags are not allowed
			if(!allow)
			{
				//Convert the brackets into HTML equivalents
				sb.Replace("<","&lt;") ;
				sb.Replace(">","&gt;") ;
				//Convert the double quote
				sb.Replace("\"","&quot;");
			}
			//Create a StringReader from the processed string of
			//the StringBuilder object
			StringReader sr = new StringReader(sb.ToString());
			StringWriter sw = new StringWriter();
			//Loop while next character exists
			while(sr.Peek()>-1)
			{
				//Read a line from the string and store it to a temp
				//variable
				string temp = sr.ReadLine();
				//write the string with the HTML break tag
				//Note here write method writes to a Internal StringBuilder
				//object created automatically
				sw.Write(temp+"<br>") ;
			}
			//Return the final processed text
			return sw.GetStringBuilder().ToString();
		}

		public static string To_DateFormat(string dtInput, string cultureInput)
		{
			try
			{
				if(cultureInput.ToUpper().Equals("US"))
				{
					CultureInfo culture = new CultureInfo("en-us"); 
					return DateTime.Parse(dtInput).ToString("dd-MMMM-yyyy",culture) ;
				}else
				{
					return DateTime.Parse(dtInput).ToString("dd/MM/yyyy") ;
				}
				
			}
			catch (Exception e)
			{
				return dtInput;
			}
		}

        public static string DecimalToStringNon(Decimal x)
        {
            //return String.Format("{0:#0.00}%", x);
            return x.ToString("000", System.Globalization.CultureInfo.InvariantCulture);
        }
        public static string FormatCurrencyVND(Decimal x)
        {
            
            //    return String.Format(CultureInfo.CreateSpecificCulture("en-us"),VNCurrency_Patterns[0], x);
                //return (x.ToString("0,0.00", CultureInfo.InvariantCulture));
                return (x.ToString("#,0.##", CultureInfo.InvariantCulture));
                //
                    // String.Format("{0:0.##}"

        }
        public static string DecimalToString(Decimal x)
        {
            string outValue = "";
            // return String.Format(CultureInfo.CreateSpecificCulture("en-us"), VNCurrency_Patterns[0], x);
            //string specifier = "#,#.00#;(#,#.00#)";
            //return (x*-1).ToString(specifier);
           // return (x.ToString("0,0.00", CultureInfo.InvariantCulture));
            if (x == 0)
                outValue = "";
            else
                outValue = TextUtils.FormatCurrencyVND(x);
            return outValue;

        }
        public static string DecimalToStringWithZero(Decimal x)
        {
            string outValue = "";
            // return String.Format(CultureInfo.CreateSpecificCulture("en-us"), VNCurrency_Patterns[0], x);
            //string specifier = "#,#.00#;(#,#.00#)";
            //return (x*-1).ToString(specifier);
            // return (x.ToString("0,0.00", CultureInfo.InvariantCulture));
            if (x == 0)
                outValue = "0";
            else
                outValue = TextUtils.FormatCurrencyVND(x);
            return outValue;

        }

        public static string showDate(DateTime dt)
        {
            return dt.CompareTo(GlobalConstant.MIN_DATE) > 0 ? dt.ToString("dd/MM/yyyy") : string.Empty;
        }

		public static string DataTableToJSON(DataTable table)
		{
			var JSONString = new StringBuilder();
			if (table.Rows.Count > 0)
			{
				JSONString.Append("[");
				for (int i = 0; i < table.Rows.Count; i++)
				{
					JSONString.Append("{");
					for (int j = 0; j < table.Columns.Count; j++)
					{
						if (j < table.Columns.Count - 1)
						{
							JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
						}
						else if (j == table.Columns.Count - 1)
						{
							JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
						}
					}
					if (i == table.Rows.Count - 1)
					{
						JSONString.Append("}");
					}
					else
					{
						JSONString.Append("},");
					}
				}
				JSONString.Append("]");
			}
			return JSONString.ToString();
		}


    }
}