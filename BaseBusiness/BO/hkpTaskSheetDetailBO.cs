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
           

            string query = $@"SELECT DISTINCT a.RoomNo, a.FacilityTask FROM dbo.hkpTaskSheetDetail a WITH (NOLOCK), dbo.hkpTaskSheet b WITH (NOLOCK) " +
                                            "WHERE a.TaskSheetID = b.ID AND  a.Status = 0 AND DATEDIFF(DAY,b.TaskSheetDate,'" + taskdateauto + "')=0 ";

            return instance.GetList<hkpTaskSheetDetailModel>(query);
        }
    }
}
