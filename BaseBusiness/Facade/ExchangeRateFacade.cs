using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ExchangeRateFacade : BaseFacadeDB
    {
        protected static ExchangeRateFacade instance = new ExchangeRateFacade(new ExchangeRateModel());
        protected ExchangeRateFacade(ExchangeRateModel model) : base(model)
        {
        }
        public static ExchangeRateFacade Instance
        {
            get { return instance; }
        }
        protected ExchangeRateFacade() : base()
        {
        }
    }
}
