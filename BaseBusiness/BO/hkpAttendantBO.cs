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
    public class hkpAttendantBO : BaseBO
    {
        private hkpAttendantFacade facade = hkpAttendantFacade.Instance;
        protected static hkpAttendantBO instance = new hkpAttendantBO();

        protected hkpAttendantBO()
        {
            this.baseFacade = facade;
        }

        public static hkpAttendantBO Instance
        {
            get { return instance; }
        }
        public static List<hkpAttendantModel> GethkpAttendantbySect(string _ListSection)
        {


            string query = $@"SELECT ID FROM dbo.hkpAttendant WITH (NOLOCK) WHERE SectionID IN ('" + _ListSection + "') ";

            return instance.GetList<hkpAttendantModel>(query);
        }
        public static List<hkpAttendantModel> GethkpAttendantProcessSource(int  _secID,string _ListAttendant)
        {


            string query = $@"SELECT DISTINCT ID FROM dbo.hkpAttendant WITH (NOLOCK) WHERE SectionID = " + _secID + " AND ID IN ('" + _ListAttendant + "') ";

            return instance.GetList<hkpAttendantModel>(query);
        }
        public static List<hkpAttendantDTOModel> AttendantsData()
        {


            string query = $@"SELECT a.*, f.Name AS [Floor], s.Code AS [Section] FROM hkpAttendant a LEFT JOIN Floor f ON a.FloorID = f.ID LEFT JOIN hkpSection s ON a.SectionID = s.ID";

            return instance.GetList<hkpAttendantDTOModel>(query);
        }
        public class hkpAttendantDTOModel 
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string MobileNo { get; set; }
            public string Floor { get; set; }
            public string Section { get; set; }
            public int FloorID { get; set; }
            public int SectionID { get; set; }
            public string JobCode { get; set; }

            public bool Monday { get; set; }
            public bool Tuesday { get; set; }
            public bool Wednesday { get; set; }
            public bool Thursday { get; set; }
            public bool Friday { get; set; }
            public bool Saturday { get; set; }
            public bool Sunday { get; set; }

            public bool IsActive { get; set; }

            public string CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime UpdatedDate { get; set; }
        }
    }
}
