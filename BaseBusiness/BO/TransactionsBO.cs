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
    public class TransactionsBO: BaseBO
    {
        private TransactionsFacade facade = TransactionsFacade.Instance;
        protected static TransactionsBO instance = new TransactionsBO();

        protected TransactionsBO()
        {
            this.baseFacade = facade;
        }

        public static TransactionsBO Instance
        {
            get { return instance; }
        }
        public static List<TransactionsModel> GetList()
        {

            string query = $"select * from Transactions where IsActive = 1 ";
            return instance.GetList<TransactionsModel>(query);
        }

        public static List<TransactionsModel> GetPaymentFO()
        {

            string query = $"select * from Transactions where TransactionGroupID = 3 and IsActive = 1 and FOPayments = 1\r\n";
            return instance.GetList<TransactionsModel>(query);
        }
    }
}
