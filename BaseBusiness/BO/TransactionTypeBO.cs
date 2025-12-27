using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class TransactionTypeBO : BaseBO
    {
        private TransactionTypeFacade facade = TransactionTypeFacade.Instance;
        protected static TransactionTypeBO instance = new TransactionTypeBO();

        protected TransactionTypeBO()
        {
            this.baseFacade = facade;
        }

        public static TransactionTypeBO Instance
        {
            get { return instance; }
        }
    }
}
