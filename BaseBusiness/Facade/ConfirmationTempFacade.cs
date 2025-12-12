using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ConfirmationTempFacade : BaseFacadeDB
    {
        protected static ConfirmationTempFacade instance = new ConfirmationTempFacade(new ConfirmationTempModel());
        protected ConfirmationTempFacade(ConfirmationTempModel model) : base(model)
        {
        }
        public static ConfirmationTempFacade Instance
        {
            get { return instance; }
        }
        protected ConfirmationTempFacade() : base()
        {
        }
    }
}
