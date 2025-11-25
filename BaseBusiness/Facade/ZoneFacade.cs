using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ZoneFacade : BaseFacadeDB
    {
        protected static ZoneFacade instance = new ZoneFacade(new ZoneModel());
        protected ZoneFacade(ZoneModel model) : base(model)
        {
        }
        public static ZoneFacade Instance
        {
            get { return instance; }
        }
        protected ZoneFacade() : base()
        {
        }
    }
}
