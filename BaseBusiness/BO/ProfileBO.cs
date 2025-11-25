using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.util;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ProfileBO : BaseBO
    {
        private ProfileFacade facade = ProfileFacade.Instance;
        protected static ProfileBO instance = new ProfileBO();

        protected ProfileBO()
        {
            this.baseFacade = facade;
        }

        public static ProfileBO Instance
        {
            get { return instance; }
        }
        public static DataTable GetAllProfile(string code, string account, string firstName, string keyWord, string city, int type, bool showSaleInCharge)
        {
            if (string.IsNullOrEmpty(code))
            {
                code = "";
            }
            if (string.IsNullOrEmpty(account))
            {
                account = "";
            }
            if (string.IsNullOrEmpty(firstName))
            {
                firstName = "";
            }
            if (string.IsNullOrEmpty(keyWord))
            {
                keyWord = "";
            }
            if (string.IsNullOrEmpty(city))
            {
                city = "";
            }

            string typeS = "";
            if (type == 0)
            {
                typeS = "1";
            }
            //Company
            else if (type == 1)
            {
                typeS = "2";
            }
            //Source
            else if (type == 2)
            {
                typeS = "3";
            }
            //Individual
            else if (type == 3)
            {
                typeS = "0";
            }
            //Group
            else if (type == 4)
            {
                typeS = "4";
            }
            //Contact
            else if (type == 5)
            {
                typeS = "5";
            }
            //All
            else if (type == 6)
            {
                typeS = "";
            }
            string _saleincharge = "";
            if (showSaleInCharge == true)
                _saleincharge = "true";
            SqlParameter[] param = new SqlParameter[]
                         {
                    new SqlParameter("@Code", code),
                    new SqlParameter("@Account", account),
                    new SqlParameter("@FirstName", firstName),
                    new SqlParameter("@Keyword", keyWord),
                    new SqlParameter("@City", city),
                    new SqlParameter("@Type", typeS),
                    new SqlParameter("@ShowSaleInCharge", _saleincharge),
            };
            DataTable myTable = DataTableHelper.getTableData("spProfileSearch_ALL", param);
            return myTable;
        }

        public static (DataTable, int) GetAllProfile2(string code, string account, string firstName, string keyWord, string city, int type, bool showSaleInCharge, int page, int pageSize)
        {
            code = code ?? "";
            account = account ?? "";
            firstName = firstName ?? "";
            keyWord = keyWord ?? "";
            city = city ?? "";

            string typeS = type switch
            {
                0 => "1", // Corporate
                1 => "2", // Company
                2 => "3", // Source
                3 => "0", // Individual
                4 => "4", // Group
                5 => "5", // Contact
                6 => "",  // All
                _ => ""
            };

            string _saleInCharge = showSaleInCharge ? "true" : "";

            SqlParameter[] param = new SqlParameter[]
            {
        new SqlParameter("@Code", code),
        new SqlParameter("@Account", account),
        new SqlParameter("@FirstName", firstName),
        new SqlParameter("@Keyword", keyWord),
        new SqlParameter("@City", city),
        new SqlParameter("@Type", typeS),
        new SqlParameter("@ShowSaleInCharge", _saleInCharge),
        new SqlParameter("@Page", page),
        new SqlParameter("@PageSize", pageSize)
            };

            DataSet dataSet = DataTableHelper.GetDataSet("spProfileSearch_ALL2", param);
            DataTable myTable = dataSet.Tables[0];
            int totalCount = Convert.ToInt32(dataSet.Tables[1].Rows[0][0]);
            return (myTable, totalCount);
        }
    }
}
