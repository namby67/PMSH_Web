using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class NationalityFacade : BaseFacadeDB
    {
        protected static NationalityFacade instance = new NationalityFacade(new NationalityModel());
        protected NationalityFacade(NationalityModel model) : base(model)
        {
        }
        public static NationalityFacade Instance
        {
            get { return instance; }
        }
        protected NationalityFacade() : base()
        {
        }
    }
}
