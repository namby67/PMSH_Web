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
    public class ShiftBO : BaseBO
    {
        private ShiftFacade facade = ShiftFacade.Instance;
        protected static ShiftBO instance = new ShiftBO();

        protected ShiftBO()
        {
            this.baseFacade = facade;
        }

        public static ShiftBO Instance
        {
            get { return instance; }
        }
        public static int GetShift(int userID)
        {
            string query = "select max(cast(InvoiceNo as int)) as InvoiceNo from FolioDetail";
            return instance.GetFirst<int>(query);
        }

        public static List<ShiftModel> GetShiftByUser(DateTime date, int userID)
        {
            string query = "SELECT * FROM Shift WHERE CAST(LoginTime AS DATE) = @Date AND Status = 0 AND UserID = @UserID";

            var parameters = new
            {
                Date = date.Date, // Ensures only the date part is used
                UserID = userID
            };

            return instance.GetList<ShiftModel>(query, parameters);
        }
    }
}
