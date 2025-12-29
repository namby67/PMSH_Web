using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PreferenceBO : BaseBO
    {
        private PreferenceFacade facade = PreferenceFacade.Instance;
        protected static PreferenceBO instance = new PreferenceBO();

        protected PreferenceBO()
        {
            this.baseFacade = facade;
        }

        public static PreferenceBO Instance
        {
            get { return instance; }
        }
    }
}
