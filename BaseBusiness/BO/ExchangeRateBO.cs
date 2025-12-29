using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ExchangeRateBO : BaseBO
    {
        private ExchangeRateFacade facade = ExchangeRateFacade.Instance;
        protected static ExchangeRateBO instance = new ExchangeRateBO();

        protected ExchangeRateBO()
        {
            this.baseFacade = facade;
        }

        public static ExchangeRateBO Instance
        {
            get { return instance; }
        }
    }
}
