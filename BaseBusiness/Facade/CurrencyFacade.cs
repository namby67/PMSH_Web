using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class CurrencyFacade : BaseFacadeDB
    {
        protected static CurrencyFacade instance = new CurrencyFacade(new CurrencyModel());
        protected CurrencyFacade(CurrencyModel model) : base(model)
        {
        }
        public static CurrencyFacade Instance
        {
            get { return instance; }
        }
        protected CurrencyFacade() : base()
        {
        }
    }
}
