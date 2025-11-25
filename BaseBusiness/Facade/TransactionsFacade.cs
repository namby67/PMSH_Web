using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseBusiness.Facade
{
    public class TransactionsFacade : BaseFacadeDB
    {
        protected static TransactionsFacade instance = new TransactionsFacade(new TransactionsModel());
        protected TransactionsFacade(TransactionsModel model) : base(model)
        {
        }
        public static TransactionsFacade Instance
        {
            get { return instance; }
        }
        protected TransactionsFacade() : base()
        {
        }
    }
}
