using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PreferenceGroupBO : BaseBO
    {
        private PreferenceGroupFacade facade = PreferenceGroupFacade.Instance;
        protected static PreferenceGroupBO instance = new PreferenceGroupBO();

        protected PreferenceGroupBO()
        {
            this.baseFacade = facade;
        }

        public static PreferenceGroupBO Instance
        {
            get { return instance; }
        }
    }
}
