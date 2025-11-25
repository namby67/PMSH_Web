using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class GenerateTransactionBO : BaseBO
    {
        private GenerateTransactionFacade facade = GenerateTransactionFacade.Instance;
        protected static GenerateTransactionBO instance = new GenerateTransactionBO();

        protected GenerateTransactionBO()
        {
            this.baseFacade = facade;
        }

        public static GenerateTransactionBO Instance
        {
            get { return instance; }
        }
    }
}
