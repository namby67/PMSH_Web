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
    public class TransactionGroupBO : BaseBO
    {
        private TransactionGroupFacade facade = TransactionGroupFacade.Instance;
        protected static TransactionGroupBO instance = new TransactionGroupBO();

        protected TransactionGroupBO()
        {
            this.baseFacade = facade;
        }

        public static TransactionGroupBO Instance
        {
            get { return instance; }
        }


        public static List<TransactionGroupModel> GetList()
        {

            string query = $"select * from TransactionGroup ";
            return instance.GetList<TransactionGroupModel>(query);
        }
    }
}
