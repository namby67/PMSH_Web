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
            string date = taskdateauto.ToString("yyyy-MM-dd");

            string query = $@"
        SELECT MAX(TaskSheetNo) AS TaskSheetNo
        FROM dbo.hkpTaskSheet WITH (NOLOCK)
        WHERE CAST(TaskSheetDate AS DATE) = '{date}'";

            return instance.GetList<hkpTaskSheetModel>(query);
        }

    }
}
