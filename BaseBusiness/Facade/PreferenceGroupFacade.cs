using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PreferenceGroupFacade : BaseFacadeDB
    {
        protected static PreferenceGroupFacade instance = new PreferenceGroupFacade(new PreferenceGroupModel());
        protected PreferenceGroupFacade(PreferenceGroupModel model) : base(model)
        {
        }
        public static PreferenceGroupFacade Instance
        {
            get { return instance; }
        }
        protected PreferenceGroupFacade() : base()
        {
        }
    }
}
