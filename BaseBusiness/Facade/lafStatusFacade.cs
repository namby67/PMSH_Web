using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class lafStatusFacade : BaseFacadeDB
    {
        protected static lafStatusFacade instance = new lafStatusFacade(new lafStatusModel());
        protected lafStatusFacade(lafStatusModel model) : base(model)
        {
        }
        public static lafStatusFacade Instance
        {
            get { return instance; }
        }
        protected lafStatusFacade() : base()
        {
        }
    }
}
