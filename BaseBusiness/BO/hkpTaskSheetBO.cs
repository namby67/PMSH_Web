using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class hkpTaskSheetBO : BaseBO
    {
        private hkpTaskSheetFacade facade = hkpTaskSheetFacade.Instance;
        protected static hkpTaskSheetBO instance = new hkpTaskSheetBO();

        protected hkpTaskSheetBO()
        {
            this.baseFacade = facade;
        }

        public static hkpTaskSheetBO Instance
        {
            get { return instance; }
        }
        public static List<hkpTaskSheetModel> GetMaxTasksheetNo(DateTime taskdateauto)
        {


            string query = $@"SELECT  MAX(TaskSheetNo) as TaskSheetNo FROM dbo.hkpTaskSheet WITH (NOLOCK) WHERE DATEDIFF(day,TaskSheetDate, '" + taskdateauto + "') = 0 ";

            return instance.GetList<hkpTaskSheetModel>(query);
        }
    }
}
