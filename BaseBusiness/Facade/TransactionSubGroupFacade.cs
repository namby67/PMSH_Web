using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class TransactionSubGroupFacade : BaseFacadeDB
    {
        protected static TransactionSubGroupFacade instance = new TransactionSubGroupFacade(new TransactionSubGroupModel());
        protected TransactionSubGroupFacade(TransactionSubGroupModel model) : base(model)
        {
        }
        public static TransactionSubGroupFacade Instance
        {
            get { return instance; }
        }
        protected TransactionSubGroupFacade() : base()
        {
        }
    }
}
