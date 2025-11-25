using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class MarketTypeFacade : BaseFacadeDB
    {
        protected static MarketTypeFacade instance = new MarketTypeFacade(new MarketTypeModel());
        protected MarketTypeFacade(MarketTypeModel model) : base(model)
        {
        }
        public static MarketTypeFacade Instance
        {
            get { return instance; }
        }
        protected MarketTypeFacade() : base()
        {
        }
    }
}
