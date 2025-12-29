using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ConfigSystemFacade : BaseFacadeDB
    {
        protected static ConfigSystemFacade instance = new ConfigSystemFacade(new ConfigSystemModel());
        protected ConfigSystemFacade(ConfigSystemModel model) : base(model)
        {
        }
        public static ConfigSystemFacade Instance
        {
            get { return instance; }
        }
        protected ConfigSystemFacade() : base()
        {
        }
    }
}
