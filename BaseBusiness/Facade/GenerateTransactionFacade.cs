using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class GenerateTransactionFacade : BaseFacadeDB
    {
        protected static GenerateTransactionFacade instance = new GenerateTransactionFacade(new GenerateTransactionModel());
        protected GenerateTransactionFacade(GenerateTransactionModel model) : base(model)
        {
        }
        public static GenerateTransactionFacade Instance
        {
            get { return instance; }
        }
        protected GenerateTransactionFacade() : base()
        {
        }
    }
}
