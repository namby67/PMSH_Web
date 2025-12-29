using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PreferenceFacade : BaseFacadeDB
    {
        protected static PreferenceFacade instance = new PreferenceFacade(new PreferenceModel());
        protected PreferenceFacade(PreferenceModel model) : base(model)
        {
        }
        public static PreferenceFacade Instance
        {
            get { return instance; }
        }
        protected PreferenceFacade() : base()
        {
        }
    }
}
