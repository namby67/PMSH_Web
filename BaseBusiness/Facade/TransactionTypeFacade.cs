using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class TransactionTypeFacade : BaseFacadeDB
    {
        protected static TransactionTypeFacade instance = new TransactionTypeFacade(new TransactionTypeModel());
        protected TransactionTypeFacade(TransactionTypeModel model) : base(model)
        {
        }
        public static TransactionTypeFacade Instance
        {
            get { return instance; }
        }
        protected TransactionTypeFacade() : base()
        {
        }
    }
}
