using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace BaseBusiness.util
{
   public class StaticParam
   {
       public static string errDefault = "Please input valid data to red box form before submit!";
       public static int inactive_status = 0;
       public static int active_status = 1;
       public static int default_novalue = -1;
       public static string[] ACTIVE_STATUS = { "Deleted", "Active" };
       
       //Is Admin
       public static int Admin = 1;

       public static DateTime mindate=new DateTime(1900,1,1);
       public static DateTime maxdate = new DateTime(9999,1, 1);
       
       //DELTE MARK
       public static string del_mark = "-Deleted";

       public static string cultureInfoEN = "en-GB";


       public const int code_only = 0;
       public const int name_only = 1;
       public const int code_name = 2;
       public const int name_code = 3;


       public static string HR_AVATAR_SIGNATURE_FILE_STORE = "FilesAttach/";

    }
}
