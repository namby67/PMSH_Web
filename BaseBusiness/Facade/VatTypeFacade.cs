using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class VatTypeFacade : BaseFacadeDB
    {
        protected static VatTypeFacade instance = new VatTypeFacade(new VatTypeModel());
        protected VatTypeFacade(VatTypeModel model) : base(model)
        {
        }
        public static VatTypeFacade Instance
        {
            get { return instance; }
        }
        protected VatTypeFacade() : base()
        {
        }
    }
}
