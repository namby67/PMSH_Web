using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class CountryFacade : BaseFacadeDB
    {
        protected static CountryFacade instance = new CountryFacade(new CountryModel());
        protected CountryFacade(CountryModel model) : base(model)
        {
        }
        public static CountryFacade Instance
        {
            get { return instance; }
        }
        protected CountryFacade() : base()
        {
        }
    }
}
