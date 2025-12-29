using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class WaitListFacade : BaseFacadeDB
    {
        protected static WaitListFacade instance = new WaitListFacade(new WaitListModel());
        protected WaitListFacade(WaitListModel model) : base(model)
        {
        }
        public static WaitListFacade Instance
        {
            get { return instance; }
        }
        protected WaitListFacade() : base()
        {
        }
    }
}
