using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ConfirmationConfigFacade : BaseFacadeDB
    {
        protected static ConfirmationConfigFacade instance = new ConfirmationConfigFacade(new ConfirmationConfigModel());
        protected ConfirmationConfigFacade(ConfirmationConfigModel model) : base(model)
        {
        }
        public static ConfirmationConfigFacade Instance
        {
            get { return instance; }
        }
        protected ConfirmationConfigFacade() : base()
        {
        }
    }
}
