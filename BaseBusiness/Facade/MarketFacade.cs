using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class MarketFacade : BaseFacadeDB
    {
        protected static MarketFacade instance = new MarketFacade(new MarketModel());
        protected MarketFacade(MarketModel model) : base(model)
        {
        }
        public static MarketFacade Instance
        {
            get { return instance; }
        }
        protected MarketFacade() : base()
        {
        }
    }
}
