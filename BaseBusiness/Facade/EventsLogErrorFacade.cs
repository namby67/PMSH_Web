using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class EventsLogErrorFacade : BaseFacadeDB
    {
        protected static EventsLogErrorFacade instance = new EventsLogErrorFacade(new EventsLogErrorModel());
        protected EventsLogErrorFacade(EventsLogErrorModel model) : base(model)
        {
        }
        public static EventsLogErrorFacade Instance
        {
            get { return instance; }
        }
        protected EventsLogErrorFacade() : base()
        {
        }
    }
}
