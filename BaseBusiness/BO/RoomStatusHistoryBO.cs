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
    public class RoomStatusHistoryBO : BaseBO
    {
        private RoomStatusHistoryFacade facade = RoomStatusHistoryFacade.Instance;
        protected static RoomStatusHistoryBO instance = new RoomStatusHistoryBO();

        protected RoomStatusHistoryBO()
        {
            this.baseFacade = facade;
        }

        public static RoomStatusHistoryBO Instance
        {
            get { return instance; }
        }
        public  static void InsertHistory(string roomNo, string oldValue, string newValue, DateTime systemDate, string computerName, string action, int objectID, string tableName,string userName)
        {
            RoomStatusHistoryModel modelH = new RoomStatusHistoryModel();
            modelH.ChangeDate = systemDate;
            modelH.OldValue = oldValue;
            modelH.NewValue = newValue;
            modelH.RoomNo = roomNo;
            modelH.ComputerName = computerName;
            modelH.UserName = userName;
            modelH.Action = action;
            modelH.ObjectID = objectID;
            modelH.TableName = tableName;
            RoomStatusHistoryBO.instance.Insert(modelH);
        }
    }
}
