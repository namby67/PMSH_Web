using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class FormAndFunctionFacade : BaseFacadeDB
    {
        protected static FormAndFunctionFacade instance = new FormAndFunctionFacade(new FormAndFunctionModel());
        protected FormAndFunctionFacade(FormAndFunctionModel model) : base(model)
        {
        }
        public static FormAndFunctionFacade Instance
        {
            get { return instance; }
        }
        protected FormAndFunctionFacade() : base()
        {
        }
    }
}
