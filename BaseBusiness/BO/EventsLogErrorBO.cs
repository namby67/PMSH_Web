using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class EventsLogErrorBO : BaseBO
    {
        private EventsLogErrorFacade facade = EventsLogErrorFacade.Instance;
        protected static EventsLogErrorBO instance = new EventsLogErrorBO();

        protected EventsLogErrorBO()
        {
            this.baseFacade = facade;
        }

        public static EventsLogErrorBO Instance
        {
            get { return instance; }
        }
    }
}
