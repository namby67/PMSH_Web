using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;
using Microsoft.Data.SqlClient;

namespace BaseBusiness.BO
{
    using BaseBusiness.Model;
    using Dapper;
    public class ZoneBO : BaseBO
    {
        private ZoneFacade facade = ZoneFacade.Instance;
        protected static ZoneBO instance = new ZoneBO();

        protected ZoneBO()
        {
            this.baseFacade = facade;
        }

        public static ZoneBO Instance
        {
            get { return instance; }
        
        }
        public static List<RoomAvailabilitySummaryDTO> TotalRoomNight(string code)
        {

            string query = $"SELECT TotalRoomNight, TotalAvail FROM dbo.Zone where Code IN (" + code + ")";

            return instance.GetList<RoomAvailabilitySummaryDTO>(query);
        }
        public class RoomAvailabilitySummaryDTO
        {
            public int TotalRoomNight { get; set; }
            public int TotalAvail { get; set; }
        }
    }
}
