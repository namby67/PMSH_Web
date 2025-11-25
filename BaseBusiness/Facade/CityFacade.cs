using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class CityFacade : BaseFacadeDB
    {
        protected static CityFacade instance = new CityFacade(new CityModel());
        protected CityFacade(CityModel model) : base(model)
        {
        }
        public static CityFacade Instance
        {
            get { return instance; }
        }
        protected CityFacade() : base()
        {
        }
    }
}
