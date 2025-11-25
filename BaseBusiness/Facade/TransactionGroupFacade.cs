using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class TransactionGroupFacade : BaseFacadeDB
    {
        protected static TransactionGroupFacade instance = new TransactionGroupFacade(new TransactionGroupModel());
        protected TransactionGroupFacade(TransactionGroupModel model) : base(model)
        {
        }
        public static TransactionGroupFacade Instance
        {
            get { return instance; }
        }
        protected TransactionGroupFacade() : base()
        {
        }
    }
}
