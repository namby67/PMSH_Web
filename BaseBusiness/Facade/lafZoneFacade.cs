using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class lafZoneFacade : BaseFacadeDB
    {
        protected static lafZoneFacade instance = new lafZoneFacade(new lafZoneModel());
        protected lafZoneFacade(lafZoneModel model) : base(model)
        {
        }
        public static lafZoneFacade Instance
        {
            get { return instance; }
        }
        protected lafZoneFacade() : base()
        {
        }

    }
}
