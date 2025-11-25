using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;

namespace BaseBusiness.BO
{
    public class TransactionSubGroupBO : BaseBO
    {
        private TransactionSubGroupFacade facade = TransactionSubGroupFacade.Instance;
        protected static TransactionSubGroupBO instance = new TransactionSubGroupBO();

        protected TransactionSubGroupBO()
        {
            this.baseFacade = facade;
        }

        public static TransactionSubGroupBO Instance
        {
            get { return instance; }
        }
        public static List<TransactionSubGroupModel> GetList()
        {

            string query = $"select * from TransactionSubGroup ";
            return instance.GetList<TransactionSubGroupModel>(query);
        }
    }
}
