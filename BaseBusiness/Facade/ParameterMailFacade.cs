using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ParameterMailFacade : BaseFacadeDB
    {
        protected static ParameterMailFacade instance = new ParameterMailFacade(new ParameterMailModel());
        protected ParameterMailFacade(ParameterMailModel model) : base(model)
        {
        }
        public static ParameterMailFacade Instance
        {
            get { return instance; }
        }
        protected ParameterMailFacade() : base()
        {
        }
    }
}
