using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ShiftFacade : BaseFacadeDB
    {
        protected static ShiftFacade instance = new ShiftFacade(new ShiftModel());
        protected ShiftFacade(ShiftModel model) : base(model)
        {
        }
        public static ShiftFacade Instance
        {
            get { return instance; }
        }
        protected ShiftFacade() : base()
        {
        }
    }
}
