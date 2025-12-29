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
    public class hkpTaskSheetDetailBO : BaseBO
    {
        private hkpTaskSheetDetailFacade facade = hkpTaskSheetDetailFacade.Instance;
        protected static hkpTaskSheetDetailBO instance = new hkpTaskSheetDetailBO();

        protected hkpTaskSheetDetailBO()
        {
            this.baseFacade = facade;
        }

        public static hkpTaskSheetDetailBO Instance
        {
            get { return instance; }
        }
        public static List<hkpTaskSheetDetailModel> GethkpTaskSheetDetail(DateTime taskdateauto)
        {
            string date = taskdateauto.ToString("yyyy-MM-dd");

            string query = $@"
        SELECT DISTINCT a.RoomNo, a.FacilityTask 
        FROM dbo.hkpTaskSheetDetail a WITH (NOLOCK)
        JOIN dbo.hkpTaskSheet b WITH (NOLOCK) ON a.TaskSheetID = b.ID
        WHERE a.Status = 0
          AND CAST(b.TaskSheetDate AS DATE) = '{date}'";

            return instance.GetList<hkpTaskSheetDetailModel>(query);
        }

    }
}
